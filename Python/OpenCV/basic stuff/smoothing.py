import cv2 as cv
import numpy as np

img = cv.imread('../Resources/Photos/cats.jpg')

cv.imshow('cats',img)

#averaging
average= cv.blur(img,(3,3))
cv.imshow('average blur',average)

#gaussianBlur
gauss= cv.GaussianBlur(img,(3,3),sigmaX=0)
cv.imshow('gaussian blur',gauss)

#median blur
median = cv.medianBlur(img,3)
cv.imshow('median blur',median)

#Bilateral blur
bilateral = cv.bilateralFilter(img,5,15,15)
cv.imshow('bilateral filter',bilateral)


cv.waitKey(0)