import cv2 as cv
import numpy as np

img = cv.imread('Resources/Photos/cats.jpg')
cv.imshow('cats',img)

gray = cv.cvtColor(img, cv.COLOR_BGR2GRAY)
cv.imshow('gray',gray)

threshold,thresh= cv.threshold(gray,225,255,cv.THRESH_BINARY)
cv.imshow('Simple threshhold',thresh) 

threshold_inv,thresh_inv= cv.threshold(gray,225,255,cv.THRESH_BINARY_INV)
cv.imshow('Simple threshold_inv',thresh_inv) 


#adaptive thresh holding
adaptive_thresh =cv.adaptiveThreshold(gray,255,cv.ADAPTIVE_THRESH_MEAN_C,cv.THRESH_BINARY,11, 3)
cv.imshow('adaptive thresholding',adaptive_thresh) 

cv.waitKey(0)