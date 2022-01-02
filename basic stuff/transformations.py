import cv2 as cv
import numpy as np

img = cv.imread('../Resources/Photos/park.jpg')

#translation
def translate(img,x,y):
    transMat= np.float32([[1,0,x],[0,1,y]])
    print(transMat)
    dimensions= (img.shape[1],img.shape[0])
    return cv.warpAffine(img,transMat,dimensions) 

#rotation
def rotate(img,angle,rotPoint=None):
    (height,width) = img.shape[:2]
    if rotPoint==None:
        rotPoint= (width//2,height//2)
    
    rotMat= cv.getRotationMatrix2D(rotPoint,angle,1.0)
    dimensions= (width,height)
    return cv.warpAffine(img,rotMat,dimensions)


#resizing
resized = cv.resize(img,(500,500),interpolation=cv.INTER_AREA)


#Flipping
flip = cv.flip(img,-1)  

#cropping
cropped = img[200:400,300:400]



translated = translate(img,-100,100)
rotatedImg= rotate(img,45)
cv.imshow('Boston',img)
# cv.imshow('Translated',translated)
# cv.imshow('Rotated',rotatedImg)
# cv.imshow('Resized',resized)
# cv.imshow('flip',flip)
cv.imshow('cropped',cropped)
cv.waitKey(0)
