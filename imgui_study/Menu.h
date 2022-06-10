#pragma once
#include <algorithm>
#define IMGUI_LEFT_LABEL(func, label, ...) (ImGui::TextUnformatted(label),  func("##" label, __VA_ARGS__))


void showAll();
void showAutovehiculeWindow();
void showFPS(const ImVec2 );
void searchAll();
void showTable(vector<Autoturism>& items);
void AddAutovehicul();
const char* msg = "Meniul este prezentat sub forma tab-urilor de asupra.\n\
 Selectati tab-ul pentru care doriti sa realizati operatia";

void showAutovehiculeWindow() {
    ImGui::Begin("Meniu principal - Flota auto");

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
            ImGui::EndTabItem();
        }
        if (ImGui::BeginTabItem("Sterge"))
        {
            ImGui::Text("Sterge un autoturism");
            ImGui::EndTabItem();
        }
        if (ImGui::BeginTabItem("Setari"))
        {
            ImGui::Text("Setari");
            ImGui::EndTabItem();
        }
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

void showTable(vector<Autoturism>& items) {



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
                    qsort(&items[0], (size_t)items.size(), sizeof(items[0]), CompareWithSortSpecs);
            }
        for (int i = 0; i < items.size(); i++) {
            Autoturism* item = &items[i];
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
                    qsort(&items[0], (size_t)items.size(), sizeof(items[0]), CompareWithSortSpecs);
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
    vector<Autoturism>& items = FLotaAuto::getVector();
    showTable(items);
}

void searchAll() {
    static ImGuiTextFilter  Filter;
    vector<Autoturism>& items = FLotaAuto::getVector();
    Filter.Draw("Filtru", 180);
    showTable(items,Filter);

    
}


void AddAutovehicul() {
    static char numar[256] = "";
    static char marca[256] = "";
    static char model[256] = "";
    static char tip[256] = "";
    static char culoare[256] = "";

    IMGUI_LEFT_LABEL(ImGui::InputText, "numar  ", numar,128);
    IMGUI_LEFT_LABEL(ImGui::InputText, "marca  ", marca,128);
    IMGUI_LEFT_LABEL(ImGui::InputText, "model  ", model,128);
    IMGUI_LEFT_LABEL(ImGui::InputText, "tip    ", tip,128);
    IMGUI_LEFT_LABEL(ImGui::InputText, "culoare", culoare,128);
    ImGui::PushStyleColor(ImGuiCol_Button, (ImVec4)ImColor::HSV(3 / 7.0f, 0.6f, 0.6f));
    ImGui::PushStyleColor(ImGuiCol_ButtonHovered, (ImVec4)ImColor::HSV(3 / 7.0f, 0.7f, 0.7f));
    ImGui::PushStyleColor(ImGuiCol_ButtonActive, (ImVec4)ImColor::HSV(3 / 7.0f, 0.8f, 0.8f));
    ImGui::InvisibleButton("##padded-text", ImVec2(5, 5));
    if (ImGui::Button("Adauga")) {
        FLotaAuto::Add(marca,  model,  tip,  culoare,  numar);
    }
    ImGui::PopStyleColor(3);

}

