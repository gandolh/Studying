cmake_minimum_required(VERSION 3.8)
project(LearnOpenGL)

## Find dependencies
find_package(glfw3 REQUIRED)
find_package(glad REQUIRED)
find_package(glm REQUIRED)
find_package(freetype REQUIRED)
find_package(imgui REQUIRED)

# stb does not have a CMake build, but is header-only
find_path(STB_INCLUDE_DIRS "stb.h") 

## Create main executable
add_executable(main source/Main.cpp)
target_include_directories(main 
  PRIVATE 
    ${STB_INCLUDE_DIRS}
    "${CMAKE_CURRENT_LIST_DIR}/source"
)
target_link_libraries(
  main
  PRIVATE
    freetype
    glfw
    glad::glad
    glm::glm
    imgui::imgui
)
