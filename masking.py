import cv2 as cv
import numpy as np

img = cv.imread('Resources/Photos/cats.jpg')
cv.imshow('cats',img)

blank = np.zeros(img.shape[:2],dtype='uint8')
# cv.imshow('blank',blank)


circle= cv.circle(blank,(img.shape[1]//2,img.shape[0]//2),100,255,-1)
rect= cv.rectangle(blank.copy(),(img.shape[1]//2-150,img.shape[0]//2-150),(370+150,370+150),255,-1)
weird_shape= cv.bitwise_xor(circle,rect)
cv.imshow('weird_shape',weird_shape)
cv.imshow('circle',circle)
cv.imshow('rect',rect)

# cv.imshow('mask',mask)

masked = cv.bitwise_and(img,img,mask=weird_shape)
cv.imshow('masked',masked)



cv.waitKey(0)
