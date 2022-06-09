#pragma once
enum MenuWindow {
    MainScreen,
    ViewAll,
    SearchCar,
    AddCar,
    UpdateCar,
    DeleteCar,
    Setari
};

const char* msg = "Meniul este prezentat sub forma tab-urilor de asupra.\n\
 Selectati tab-ul pentru care doriti sa realizati operatia";

void showMainMenu() {
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
            ImGui::EndTabItem();
        }
        if (ImGui::BeginTabItem("Cauta"))
        {
            ImGui::Text("Cauta un autoturism");
            ImGui::EndTabItem();
        }
        if (ImGui::BeginTabItem("Adauga"))
        {
            ImGui::Text("Adauga un autoturism");
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



void showSettings( bool& show_demo_window, ImVec4& clear_color) {

        static float f = 0.0f;
        static int counter = 0;

        ImGui::Begin("Meniu principal");

        ImGui::Checkbox("Demo Window", &show_demo_window);      // Edit bools storing our window open/close state

        ImGui::ColorEdit3("clear color", (float*)&clear_color); // Edit 3 floats representing a color

        if (ImGui::Button("Button"))                            // Buttons return true when clicked (most widgets return true when edited/activated)
            counter++;
        //ImGui::SameLine();
        ImGui::Text("counter = %d", counter);
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