#pragma once
#pragma warning(disable : 4996)
#include <algorithm>
#define IMGUI_LEFT_LABEL(func, label, ...) (ImGui::TextUnformatted(label),  func("##" label, __VA_ARGS__))




void showAll();
void showAutovehiculeWindow();
void showFPS(const ImVec2 );
void searchAll();
void showTable(vector<Autoturism>& items, BtnAction btn_action);
void showTable(vector<Autoturism>& items, ImGuiTextFilter& Filter);
void AddAutovehicul();
void RemoveAutovehicul();
void UpdateTabContent();
void GoBackUpdateWindow();
const char* msg = "Meniul este prezentat sub forma tab-urilor de asupra.\n\
 Selectati tab-ul pentru care doriti sa realizati operatia";
enum UpdateState {
    Search,
    Edit
};

struct UpdateWindow {
    UpdateState screenActualizeaza = UpdateState::Search;
    int indexEditingItem = 0;
    bool editInitialised = false;
}updateWindow;

void showAutovehiculeWindow() {
    static bool use_work_area = true;
    static bool p_open = true;
    static ImGuiWindowFlags flags = ImGuiWindowFlags_NoDecoration | ImGuiWindowFlags_NoMove | ImGuiWindowFlags_NoSavedSettings;

    // We demonstrate using the full viewport area or the work area (without menu-bars, task-bars etc.)
    // Based on your use case you may want one of the other.
    const ImGuiViewport* viewport = ImGui::GetMainViewport();
    ImGui::SetNextWindowPos(use_work_area ? viewport->WorkPos : viewport->Pos);
    ImGui::SetNextWindowSize(use_work_area ? viewport->WorkSize : viewport->Size);


    ImGui::Begin("Meniu principal - Flota auto", &p_open, flags);

    if (ImGui::BeginTabBar("Meniu principal"))
    {
        if (ImGui::BeginTabItem("Ajutor"))
        {
            
            ImGui::Text(msg);
            ImGui::EndTabItem();
        }
        if (ImGui::BeginTabItem("Vezi tot"))
        {
            ImGui::Text("Vezi toate autoturismele");
            showAll();
            ImGui::EndTabItem();
        }
        if (ImGui::BeginTabItem("Cauta"))
        {
            ImGui::Text("Cauta un autoturism");
            searchAll();
            ImGui::EndTabItem();
        }
        if (ImGui::BeginTabItem("Adauga"))
        {
            ImGui::Text("Adauga un autoturism");
            AddAutovehicul();
            ImGui::EndTabItem();
        }
        if (ImGui::BeginTabItem("Actualizeaza"))
        {
            ImGui::Text("Actualizeaza un autoturism");
            UpdateTabContent();
            ImGui::EndTabItem();
        }
        if (ImGui::BeginTabItem("Sterge"))
        {
            ImGui::Text("Sterge un autoturism");
            RemoveAutovehicul();
            ImGui::EndTabItem();
        }
      /*  if (ImGui::BeginTabItem("Setari"))
        {
            ImGui::Text("Setari");
            ImGui::EndTabItem();
        }*/
        ImGui::EndTabBar();
    }

    ImGui::End();
}

void showFPS(const ImVec2 displaySize) {
    bool shown = true;
    ImGuiWindowFlags corner =
        ImGuiWindowFlags_NoMove |
        ImGuiWindowFlags_NoResize |
        ImGuiWindowFlags_NoCollapse |
        ImGuiWindowFlags_NoSavedSettings |
        ImGuiWindowFlags_AlwaysAutoResize |
        ImGuiWindowFlags_NoTitleBar;
    ImGui::SetNextWindowPos(ImVec2(displaySize.x - 60,0));
    ImGui::Begin("fpsss",&shown, corner);
    ImGui::Text("%d FPS", int(ImGui::GetIO().Framerate));
    ImGui::End();
}

void showTable(vector<Autoturism>& items, BtnAction btn_action) {



    const float TEXT_BASE_WIDTH = ImGui::CalcTextSize("A").x;
    const float TEXT_BASE_HEIGHT = ImGui::GetTextLineHeightWithSpacing();

    //ImGui::PushID("Tables");
    // Expose a few Borders related flags interactively
    static ImGuiTableFlags flags = ImGuiTableFlags_ScrollY | ImGuiTableFlags_BordersInnerH | ImGuiTableFlags_Reorderable | ImGuiTableFlags_Hideable
        | ImGuiTableFlags_RowBg | ImGuiTableFlags_BordersV | ImGuiTableFlags_Resizable | ImGuiTableFlags_Sortable;
    static bool display_headers = true;

    if (ImGui::BeginTable("Vezi toate", 5 + (btn_action != BtnAction::None ? 1 : 0), flags))
    {
        ImGui::TableSetupScrollFreeze(0, 1);
        // Display headers so we can inspect their interaction with borders.
        if (display_headers)
        {
            ImGui::TableSetupColumn("Numar", ImGuiTableColumnFlags_DefaultSort, 0.0f, AutoturismColumnID_numar);
            ImGui::TableSetupColumn("Marca", 0, 0.0f, AutoturismColumnID_marca);
            ImGui::TableSetupColumn("Model", 0, 0.0f, AutoturismColumnID_model);
            ImGui::TableSetupColumn("Tip", 0, 0.0f, AutoturismColumnID_tip);
            ImGui::TableSetupColumn("Culoare", 0, 0.0f, AutoturismColumnID_culoare);
            if(btn_action != BtnAction::None)
                ImGui::TableSetupColumn("", 0, 0.0f );
            ImGui::TableSetupScrollFreeze(0, 1); // Make row always visible
            ImGui::TableHeadersRow();
        }
        // Sort our data if sort specs have been changed!
        if (ImGuiTableSortSpecs* sorts_specs = ImGui::TableGetSortSpecs())
            if (sorts_specs->SpecsDirty)
            {
                Autoturism::s_current_sort_specs = NULL;
                sorts_specs->SpecsDirty = false;
                Autoturism::s_current_sort_specs = sorts_specs;
                if (items.size() > 1)
                    qsort(&items[0], (size_t)items.size(), sizeof(items[0]), CompareWithSortSpecs);
            }
        for (int i = 0; i < items.size(); i++) {
            Autoturism& item = items[i];
            // Display a data item
            ImGui::TableNextRow();
            ImGui::TableNextColumn();
            ImGui::TextUnformatted(item.numar.c_str());
            ImGui::TableNextColumn();
            ImGui::TextUnformatted(item.marca.c_str());
            ImGui::TableNextColumn();
            ImGui::TextUnformatted(item.model.c_str());
            ImGui::TableNextColumn();
            ImGui::TextUnformatted(item.tip.c_str());
            ImGui::TableNextColumn();
            ImGui::TextUnformatted(item.culoare.c_str());
            if (btn_action == BtnAction::Remove) {
                ImGui::TableNextColumn();
                ImGui::PushStyleColor(ImGuiCol_Button, (ImVec4)ImColor::HSV(0, 0.6f, 0.6f));
                ImGui::PushStyleColor(ImGuiCol_ButtonHovered, (ImVec4)ImColor::HSV(0, 0.7f, 0.7f));
                ImGui::PushStyleColor(ImGuiCol_ButtonActive, (ImVec4)ImColor::HSV(0, 0.8f, 0.8f));
                ImGui::PushID(i);
                if (ImGui::Button("sterge")) {
                    FlotaAuto::Remove(i);
                }
                ImGui::PopID();
                ImGui::PopStyleColor(3);
            }
            else if (btn_action == BtnAction::Update) {
                ImGui::TableNextColumn();
                const float hue = 0.6f;
                ImGui::PushStyleColor(ImGuiCol_Button, (ImVec4)ImColor::HSV(hue, 0.6f, 0.6f));
                ImGui::PushStyleColor(ImGuiCol_ButtonHovered, (ImVec4)ImColor::HSV(hue, 0.9f, 0.7f));
                ImGui::PushStyleColor(ImGuiCol_ButtonActive, (ImVec4)ImColor::HSV(hue, 0.9f, 0.8f));
                ImGui::PushID(i);
                if (ImGui::Button("Actualizeaza")) {
                    updateWindow.screenActualizeaza = UpdateState::Edit;
                    updateWindow.indexEditingItem = i;
                }
                ImGui::PopID();
                ImGui::PopStyleColor(3);
            }
        }
        ImGui::EndTable();
    }

}


void showTable(vector<Autoturism>& items, ImGuiTextFilter&  Filter ) {



    const float TEXT_BASE_WIDTH = ImGui::CalcTextSize("A").x;
    const float TEXT_BASE_HEIGHT = ImGui::GetTextLineHeightWithSpacing();

    //ImGui::PushID("Tables");
    // Expose a few Borders related flags interactively
    static ImGuiTableFlags flags = ImGuiTableFlags_ScrollY | ImGuiTableFlags_BordersInnerH | ImGuiTableFlags_Reorderable | ImGuiTableFlags_Hideable
        | ImGuiTableFlags_RowBg | ImGuiTableFlags_BordersV | ImGuiTableFlags_Resizable | ImGuiTableFlags_Sortable;
    static bool display_headers = true;

    if (ImGui::BeginTable("Vezi toate", 5, flags))
    {
        ImGui::TableSetupScrollFreeze(0, 1);
        // Display headers so we can inspect their interaction with borders.
        if (display_headers)
        {
            ImGui::TableSetupColumn("Numar", ImGuiTableColumnFlags_DefaultSort, 0.0f, AutoturismColumnID_numar);
            ImGui::TableSetupColumn("Marca", 0, 0.0f, AutoturismColumnID_marca);
            ImGui::TableSetupColumn("Model", 0, 0.0f, AutoturismColumnID_model);
            ImGui::TableSetupColumn("Tip", 0, 0.0f, AutoturismColumnID_tip);
            ImGui::TableSetupColumn("Culoare", 0, 0.0f, AutoturismColumnID_culoare);
            ImGui::TableSetupScrollFreeze(0, 1); // Make row always visible
            ImGui::TableHeadersRow();
        }
        // Sort our data if sort specs have been changed!
        if (ImGuiTableSortSpecs* sorts_specs = ImGui::TableGetSortSpecs())
            if (sorts_specs->SpecsDirty)
            {
                Autoturism::s_current_sort_specs = NULL;
                sorts_specs->SpecsDirty = false;
                Autoturism::s_current_sort_specs = sorts_specs;
                if (items.size() > 1)
                    sort(items.begin(),items.end());
            }
        for (int i = 0; i < items.size(); i++) {
            Autoturism* item = &items[i];
            bool ok = !Filter.PassFilter(item->numar.c_str());
            if (!Filter.PassFilter(item->culoare.c_str()) 
                && !Filter.PassFilter(item->marca.c_str())
                && !Filter.PassFilter(item->model.c_str())
                && !Filter.PassFilter(item->numar.c_str())
                && !Filter.PassFilter(item->tip.c_str()))
                continue;

            // Display a data item
            ImGui::TableNextRow();
            ImGui::TableNextColumn();
            ImGui::TextUnformatted(item->numar.c_str());
            ImGui::TableNextColumn();
            ImGui::TextUnformatted(item->marca.c_str());
            ImGui::TableNextColumn();
            ImGui::TextUnformatted(item->model.c_str());
            ImGui::TableNextColumn();
            ImGui::TextUnformatted(item->tip.c_str());
            ImGui::TableNextColumn();
            ImGui::TextUnformatted(item->culoare.c_str());
        }
        ImGui::EndTable();
    }

}


void showAll() {
    vector<Autoturism>& items = FlotaAuto::getVector();
    showTable(items, BtnAction::None);
}

void searchAll() {
    static ImGuiTextFilter  Filter;
    vector<Autoturism>& items = FlotaAuto::getVector();
    Filter.Draw("Filtru", 180);
    showTable(items,Filter);

    
}

void openModal() {
    
    // Always center this window when appearing
    ImVec2 center = ImGui::GetMainViewport()->GetCenter();
    ImGui::SetNextWindowPos(center, ImGuiCond_Appearing, ImVec2(0.5f, 0.5f));

    if (ImGui::BeginPopupModal("Bravo!", NULL, ImGuiWindowFlags_AlwaysAutoResize))
    {
        ImGui::Text("Ati creat cu succes o noua inregistrare!");
        ImGui::Separator();
        if (ImGui::Button("OK", ImVec2(120, 0))) { ImGui::CloseCurrentPopup(); }
        ImGui::SetItemDefaultFocus();
        ImGui::EndPopup();
    }
}

void AddAutovehicul() {
    static char numar[256] = "";
    static char marca[256] = "";
    static char model[256] = "";
    static char tip[256] = "";
    static char culoare[256] = "";

    IMGUI_LEFT_LABEL(ImGui::InputText, "Numar:  ", numar,128);
    IMGUI_LEFT_LABEL(ImGui::InputText, "Marca:  ", marca,128);
    IMGUI_LEFT_LABEL(ImGui::InputText, "Model:  ", model,128);
    IMGUI_LEFT_LABEL(ImGui::InputText, "Tip:    ", tip,128);
    IMGUI_LEFT_LABEL(ImGui::InputText, "Culoare:", culoare,128);
    ImGui::PushStyleColor(ImGuiCol_Button, (ImVec4)ImColor::HSV(3 / 7.0f, 0.6f, 0.6f));
    ImGui::PushStyleColor(ImGuiCol_ButtonHovered, (ImVec4)ImColor::HSV(3 / 7.0f, 0.7f, 0.7f));
    ImGui::PushStyleColor(ImGuiCol_ButtonActive, (ImVec4)ImColor::HSV(3 / 7.0f, 0.8f, 0.8f));
    ImGui::InvisibleButton("##padded-text", ImVec2(5, 5));
    if (ImGui::Button("Adauga")) {
        FlotaAuto::Add(marca,  model,  tip,  culoare,  numar);
        ImGui::OpenPopup("Bravo!");
    }
    openModal();
    ImGui::PopStyleColor(3);

}

void RemoveAutovehicul() {
    vector<Autoturism>& items = FlotaAuto::getVector();
    showTable(items, BtnAction::Remove);
}


void UpdateTabContent() {
    vector<Autoturism>& items = FlotaAuto::getVector();
    if (updateWindow.screenActualizeaza == UpdateState::Search)
        showTable(items, BtnAction::Update);
    else {
        //edit screen
        int index = updateWindow.indexEditingItem;
        
        static char numar[256] = "";
        static char marca[256] = "";
        static char model[256] = "";
        static char tip[256] = "";
        static char culoare[256] = "";
        if (updateWindow.editInitialised == false) {
            strcpy(numar,items[index].numar.c_str());
            strcpy(marca, items[index].marca.c_str());
            strcpy(model, items[index].model.c_str());
            strcpy(tip, items[index].tip.c_str());
            strcpy(culoare, items[index].culoare.c_str());
        }
        updateWindow.editInitialised = true;
        IMGUI_LEFT_LABEL(ImGui::InputText, "Numar:  ", numar, 256);
        IMGUI_LEFT_LABEL(ImGui::InputText, "Marca:  ", marca, 256);
        IMGUI_LEFT_LABEL(ImGui::InputText, "Model:  ", model, 256);
        IMGUI_LEFT_LABEL(ImGui::InputText, "Tip:    ", tip, 256);
        IMGUI_LEFT_LABEL(ImGui::InputText, "Culoare:", culoare, 256);
        ImGui::PushStyleColor(ImGuiCol_Button, (ImVec4)ImColor::HSV(3 / 7.0f, 0.6f, 0.6f));
        ImGui::PushStyleColor(ImGuiCol_ButtonHovered, (ImVec4)ImColor::HSV(3 / 7.0f, 0.7f, 0.7f));
        ImGui::PushStyleColor(ImGuiCol_ButtonActive, (ImVec4)ImColor::HSV(3 / 7.0f, 0.8f, 0.8f));
        ImGui::InvisibleButton("##padded-text", ImVec2(5, 5));
        if (ImGui::Button("Actualizeaza")) {
            FlotaAuto::Update(index,marca, model, tip, culoare, numar);
            GoBackUpdateWindow();
        }
        ImGui::PopStyleColor(3);
    }

    if (updateWindow.screenActualizeaza == BtnAction::Update) {
        //btn inapoi
        const float hue = 0.6f;
        ImGui::PushStyleColor(ImGuiCol_Button, (ImVec4)ImColor::HSV(hue, 0.6f, 0.6f));
        ImGui::PushStyleColor(ImGuiCol_ButtonHovered, (ImVec4)ImColor::HSV(hue, 0.9f, 0.7f));
        ImGui::PushStyleColor(ImGuiCol_ButtonActive, (ImVec4)ImColor::HSV(hue, 0.9f, 0.8f));

        if (ImGui::Button("Inapoi")) {
            GoBackUpdateWindow();
        }
        ImGui::PopStyleColor(3);
    }
}

void GoBackUpdateWindow() {
    updateWindow.screenActualizeaza = UpdateState::Search;
    updateWindow.editInitialised = false;
}