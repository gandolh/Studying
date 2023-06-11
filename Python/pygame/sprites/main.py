import pygame, sys, random 

class Crosshair(pygame.sprite.Sprite):
    def __init__(self):
        super().__init__()
        
        self.image = pygame.image.load("crosshair.png")
        self.image = pygame.transform.scale(self.image, (20,20))
        self.rect = self.image.get_rect()
        self.gunshot = pygame.mixer.Sound("gunshot.mp3")
    def shoot(self):
        self.gunshot.play()
        pygame.sprite.spritecollide(crosshair, target_group, True)
        
    def update(self):
        self.rect.center = pygame.mouse.get_pos()

class Target(pygame.sprite.Sprite):
    def __init__(self, pos_x, pos_y):
        super().__init__()
        self.image = pygame.image.load("target.png")
        self.rect = self.image.get_rect()
        self.rect.center = [pos_x, pos_y]

# init pygame
pygame.init()
clock = pygame.time.Clock()

# Screen
screen_width = 600
screen_height = 600
screen = pygame.display.set_mode((screen_width, screen_height))
background = pygame.image.load("BG.png")
background = pygame.transform.scale(background, (screen_width, screen_height))
pygame.mouse.set_visible(False)

# Crosshair
crosshair = Crosshair()
crosshair_group = pygame.sprite.Group()
crosshair_group.add(crosshair)

# Targets
target_group = pygame.sprite.Group()
for target in range(20):
    new_target = Target(random.random() * screen_width,
                         random.random() * screen_height)
    target_group.add(new_target)

# Game loop
while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()
        if event.type == pygame.MOUSEBUTTONDOWN and event.button == 1:
            crosshair.shoot()
    pygame.display.flip()
    screen.blit(background, (0, 0))
    target_group.draw(screen)
    crosshair_group.draw(screen)
    crosshair_group.update()
    clock.tick(60)