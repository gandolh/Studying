import cv2 as cv
import numpy as np

blank = np.zeros((500,500,3),dtype='uint8')


# #paint the entire image
# blank[:]=0,255,0
# blank[200:300,300:400]=0,255,255
# cv.imshow('Blank',blank)

# Draw a rectangle
# cv.rectangle(blank,(0,0),(250,250),(255,0,0),thickness=2)
# cv.rectangle(blank,(0,0),(250,250),(255,0,0),thickness=cv.FILLED)
# cv.rectangle(blank,(0,0),(250,250),(255,0,0),thickness=-1)
cv.rectangle(blank,(0,0),(blank.shape[0]//2,blank.shape[1]//2),(255,0,0),thickness=-1)
cv.circle(blank,(blank.shape[0]//2,blank.shape[1]//2), 40,(250,120,120),thickness=-1)
cv.line(blank, (100,100),(300,300),(120,0,120),thickness=2)

#write text
cv.putText(blank,'Hello',(255,255), cv.FONT_HERSHEY_TRIPLEX,1.0,(255,255,0),3)
cv.imshow('Blank',blank)
cv.waitKey(0)