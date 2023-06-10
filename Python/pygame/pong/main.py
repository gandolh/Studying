import pygame, sys
from Ball import Ball
from Player import Player
from Opponent 	import Opponent
from GameManager import GameManager
from Configuration import screen_width, screen_height, bg_color, accent_color, middle_strip, clock, screen


# Game objects
player = Player('Paddle.png',screen_width - 20,screen_height/2,5)
opponent = Opponent('Paddle.png',20,screen_width/2,5)
paddle_group = pygame.sprite.Group()
paddle_group.add(player)
paddle_group.add(opponent)

ball = Ball('Ball.png',screen_width/2,screen_height/2,4,4,paddle_group)
ball_sprite = pygame.sprite.GroupSingle()
ball_sprite.add(ball)

game_manager = GameManager(ball_sprite,paddle_group)

while True:
	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()
		if event.type == pygame.KEYDOWN:
			if event.key == pygame.K_UP:
				player.movement -= player.speed
			if event.key == pygame.K_DOWN:
				player.movement += player.speed
		if event.type == pygame.KEYUP:
			if event.key == pygame.K_UP:
				player.movement += player.speed
			if event.key == pygame.K_DOWN:
				player.movement -= player.speed
	
	# Background Stuff
	screen.fill(bg_color)
	pygame.draw.rect(screen,accent_color,middle_strip)
	
	# Run the game
	game_manager.run_game(screen)

	# Rendering
	pygame.display.flip()
	clock.tick(120)