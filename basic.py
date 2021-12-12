import cv2 as cv
img = cv.imread('Resources/Photos/cat.jpg')
cv.imshow('Cat',img)


#convert to gray
# gray= cv.cvtColor(img,cv.COLOR_BGR2GRAY)
# cv.imshow('Gray',gray)

# Blur
# blur = cv.GaussianBlur(img,(3,3),cv.BORDER_DEFAULT)
# cv.imshow('Blur',blur)

#edge cascade
#BLUR to add or reduce edges
blur = cv.GaussianBlur(img,(3,3),cv.BORDER_DEFAULT)
canny = cv.Canny(blur,125,175)
# cv.imshow('canny',canny)

#Dillating the image
dilated = cv.dilate(canny,(7,7),iterations=3)
# cv.imshow('dillated',dilated)

#Erroding
eroded = cv.erode(dilated,(3,3),iterations=1)
# cv.imshow('eroded',eroded)

#resize
resized = cv.resize(img,(500,500),interpolation=cv.INTER_CUBIC)
# cv.imshow('resized',resized)

#cropping
cropped = img[50:200,200:400]
# cv.imshow('cropped',cropped)


cv.waitKey(0)