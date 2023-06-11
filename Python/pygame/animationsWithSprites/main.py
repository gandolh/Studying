from typing import Any
import pygame, sys

class Player(pygame.sprite.Sprite):
    def __init__(self, pos_x, pos_y):
        super().__init__()
        self.sprites = []
        self.is_animating = False
        for i in range(1, 10):
            self.sprites.append(pygame.image.load(f'attack_{i}.png'))
        self.current_sprite = 0
        self.image = self.sprites[self.current_sprite]
        self.rect = self.image.get_rect() 
        self.rect.topleft = [pos_x, pos_y] 
    def animate(self):
        self.is_animating = True

    def update(self):
        if self.is_animating == True:
            self.current_sprite += 0.3
            if self.current_sprite >= len(self.sprites):
                self.is_animating = False
                self.current_sprite = 0
            self.image = self.sprites[int(self.current_sprite)]
# General setup
pygame.init()
clock = pygame.time.Clock()

# Game Screen
screen_width = 400
screen_height = 400
screen = pygame.display.set_mode((screen_width, screen_height))
pygame.display.set_caption('Sprite Animation')
 
# Creating the sprites and groups
moving_sprites = pygame.sprite.Group()
player = Player(10, 10)
moving_sprites.add(player)

while True:
    for event in pygame.event.get():
        if(event.type == pygame.QUIT):
            pygame.quit()
            sys.exit()
        if event.type == pygame.KEYDOWN:
            player.animate()
    # Drawing
    screen.fill((0,0,0))
    moving_sprites.draw(screen)
    moving_sprites.update()
    pygame.display.flip()
    clock.tick(60)

