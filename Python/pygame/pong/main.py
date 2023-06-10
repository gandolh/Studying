import pygame;
import sys;
import random;
# Initialize Pygame
pygame.mixer.pre_init(44100, -16, 2, 512)
pygame.init()
clock = pygame.time.Clock()

# Window
screen_width = 640
screen_height = 480
screen = pygame.display.set_mode((screen_width, screen_height))
pygame.display.set_caption("Pong")

# Game Rectangles
ball_size = 15
player_width = 10
player_height = 70
players_offset = 5

ball = pygame.Rect( 
    screen_width/2 - ball_size / 2, 
    screen_height/2 - ball_size / 2, 
    ball_size, 
    ball_size)
player = pygame.Rect( 
    screen_width -  player_width - players_offset, 
    screen_height/ 2 - player_height/2, 
    player_width, 
    player_height)
opponent = pygame.Rect( 
    players_offset, 
    screen_height / 2 - player_height / 2, 
    player_width, 
    player_height)


# Colors
bg_color = pygame.Color('grey12')
light_grey = (200, 200, 200)

# Speed Variables
ball_speed_x = 3 * random.choice((1, -1))
ball_speed_y = 3 * random.choice((1, -1))
player_speed = 0
opponent_speed = 7
player_acc = 7

# Text Variables
player_score = 0
opponent_score = 0
game_font = pygame.font.Font("freesansbold.ttf", 24)


# Sound
pong_sound = pygame.mixer.Sound("pong.ogg")
score_sound = pygame.mixer.Sound("score.ogg")

def ball_animation():
	global ball_speed_x, ball_speed_y
	global player_score, opponent_score
	global score_time
	ball.x += ball_speed_x
	ball.y += ball_speed_y
	if ball.top <= 0 or ball.bottom >= screen_height:
		pygame.mixer.Sound.play(pong_sound)
		ball_speed_y *= -1
	if ball.left <= 0:
		player_score += 1
		score_time = pygame.time.get_ticks()
		pygame.mixer.Sound.play(score_sound)
	if ball.right >= screen_width:
		opponent_score += 1
		score_time = pygame.time.get_ticks()
		pygame.mixer.Sound.play(score_sound)
	if ball.colliderect(player) and ball_speed_x > 0 :
		pygame.mixer.Sound.play(pong_sound)
		if abs(ball.right - player.left) < 10:
			ball_speed_x *= -1
		elif abs(ball.bottom - player.top ) < 10 and ball_speed_y > 0:
			ball_speed_y *= -1
		elif abs(ball.top - player.bottom ) < 10 and ball_speed_y < 0:
			ball_speed_y *= -1
		
	if ball.colliderect(opponent) and ball_speed_x < 0:
		pygame.mixer.Sound.play(pong_sound)
		if abs(ball.left - opponent.right) < 10:
			ball_speed_x *= -1
		elif abs(ball.bottom - opponent.top ) < 10 and ball_speed_y > 0:
			ball_speed_y *= -1
		elif abs(ball.top - opponent.bottom ) < 10 and ball_speed_y < 0:
			ball_speed_y *= -1



def player_animation():
	player.y += player_speed
	if player.top <= 0:
		player.top = 0
	if player.bottom >= screen_height:
		player.bottom = screen_height


def opponent_ai():
	if(opponent.top < ball.y):
		opponent.top += opponent_speed
	if(opponent.bottom > ball.y):
		opponent.bottom -= opponent_speed
	if opponent.top <= 0: 
		opponent.top = 0
	if opponent.bottom >= screen_height:
		opponent.bottom = screen_height


def ball_restart():
	global ball_speed_x,ball_speed_y, score_time
	current_time = pygame.time.get_ticks()
	number = game_font.render("", False, light_grey)
	if current_time - score_time  < 700:
		number = game_font.render("3", False, light_grey)
	elif current_time - score_time  < 1400:
		number = game_font.render("2", False, light_grey)
	elif current_time - score_time  < 2100:
		number = game_font.render("1", False, light_grey)

	if current_time - score_time  < 2100:
		ball_speed_x, ball_speed_y = 0, 0
		screen.blit(number, (screen_width/2 - 15, screen_height/2 - 30))
	else:
		ball_speed_x = 3 * random.choice((1, -1))
		ball_speed_y = 3 * random.choice((1, -1))
		score_time = 0
	ball.center = (screen_width // 2, screen_height // 2)

# Score timer
score_time = 1


# Game Loop
while True:
	#handling input
	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()
		if event.type == pygame.KEYDOWN:
			if event.key == pygame.K_DOWN:
				player_speed+= player_acc 
			if event.key == pygame.K_UP:
				player_speed -= player_acc
		if event.type == pygame.KEYUP:
			if event.key == pygame.K_DOWN:
				player_speed-= player_acc 
			if event.key == pygame.K_UP:
				player_speed += player_acc	


	ball_animation()
	player_animation()
	opponent_ai()

	
	#adding elements to the scene
	screen.fill(bg_color)
	pygame.draw.rect(screen, light_grey, player)
	pygame.draw.rect(screen, light_grey, opponent)
	pygame.draw.ellipse(screen, light_grey, ball)
	pygame.draw.aaline(screen, light_grey, (screen_width/2, 0), (screen_width/2, screen_height))
	if score_time:
		ball_restart()
		
	player_text = game_font.render(f"{player_score}", False, light_grey)
	screen.blit(player_text, (325, 235))

	opponent_text = game_font.render(f"{opponent_score}", False, light_grey)
	screen.blit(opponent_text, (303, 235))
	#updating the window
	pygame.display.flip()
	clock.tick(60)