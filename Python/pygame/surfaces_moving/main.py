import pygame, sys


# General setup
pygame.init()
clock = pygame.time.Clock()

# Setting up the main window
screen_width = 800
screen_height = 800
screen = pygame.display.set_mode((screen_width, screen_height))
second_surface = pygame.Surface((100, 200))
second_surface.fill((0, 130,130))
kitten = pygame.image.load('kitty.png')
kitten_rect = kitten.get_rect(topleft = (100, 200))
# print(kitten_rect.width, kitten_rect.height)
# print(kitten_rect.center)


while True:
    # Handling input
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()
    
    screen.fill((30, 30, 0))
    screen.blit(second_surface,( 0, 50))
    screen.blit(kitten, kitten_rect)
    kitten_rect.right += 1
    # Updating the window
    pygame.display.flip()
    clock.tick(60)