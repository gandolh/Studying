import pygame
import sys
import math


class Player(pygame.sprite.Sprite):
    def __init__(self):
        super().__init__()
        self.image = pygame.Surface((100,100))
        self.image.fill((255, 255, 255))
        self.rect = self.image.get_rect(center=(screen_width / 2, screen_height / 2))
    def update(self):
        self.rect.center = pygame.mouse.get_pos()
    def create_bullet(self):
        return Bullet(pygame.mouse.get_pos(), -90)

class Bullet(pygame.sprite.Sprite):
    def __init__(self, pos, direction):
        super().__init__()
        self.image = pygame.Surface((20, 10))
        self.image.fill((255, 0, 0))
        self.rect = self.image.get_rect(center=pos)
        self.direction = direction
        self.speed = pygame.math.Vector2(0, 10)
        self.speed.rotate_ip(self.direction)
    def update(self):
        self.rect.move_ip(self.speed)
        if self.rect.left > screen_width or self.rect.right < 0:
            self.kill()
        if self.rect.top > screen_height or self.rect.bottom < 0:
            self.kill()
    

# Basics
pygame.init()
clock = pygame.time.Clock()
screen_width, screen_height = 800, 800
screen = pygame.display.set_mode((screen_width, screen_height))
pygame.mouse.set_visible(False)

player = Player()
player_group = pygame.sprite.Group()
player_group.add(player)

bullet_group = pygame.sprite.Group()

while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()
        if event.type == pygame.MOUSEBUTTONDOWN:
            bullet_group.add(player.create_bullet())
    # Drawing
    screen.fill((30, 30, 30))
    player_group.draw(screen)
    bullet_group.draw(screen)
    player_group.update()
    bullet_group.update()
    pygame.display.flip()
    clock.tick(30)
