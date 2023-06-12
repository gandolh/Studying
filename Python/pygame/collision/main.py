import pygame, sys

def bouncing_rect():
    global x_speed, y_speed, other_speed
    moving_rect.x += x_speed
    moving_rect.y += y_speed
    other_rect.x += other_speed
    if moving_rect.left <= 0 or moving_rect.right >= screen_width:
        x_speed *= -1
    if moving_rect.top <= 0 or moving_rect.bottom >= screen_height:
        y_speed *= -1
    if other_rect.left <= 0 or other_rect.right >= screen_width:
        other_speed *= -1
    collision_tolerance = 10
    if moving_rect.colliderect(other_rect):
        if abs(other_rect.top - moving_rect.bottom) < collision_tolerance and y_speed > 0:
            y_speed *= -1
        if abs(other_rect.bottom - moving_rect.top) < collision_tolerance and y_speed < 0:
            y_speed *= -1
        if abs(other_rect.right - moving_rect.left) < collision_tolerance and x_speed < 0:
            x_speed *= -1
        if abs(other_rect.left - moving_rect.right) < collision_tolerance and x_speed > 0:
            x_speed *= -1

pygame.init()
clock = pygame.time.Clock()

screen_width = 800
screen_height = 800
screen = pygame.display.set_mode((screen_width, screen_height))

moving_rect = pygame.Rect(350,350,100,100)
x_speed = 5
y_speed = 4

other_rect = pygame.Rect(300,600,200,100)
other_speed = 2



while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()
    screen.fill((30, 30, 30))
    pygame.draw.rect(screen, (255, 255, 255), moving_rect)
    pygame.draw.rect(screen, (20, 200, 120), other_rect)
    bouncing_rect()
    pygame.display.flip()
    clock.tick(60)

