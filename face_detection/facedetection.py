import cv2 as cv

# img = cv.imread('Resources/Photos/lady.jpg')
img = cv.imread('../Resources/Photos/group 1.jpg')
# cv.imshow('lady',img)

gray= cv.cvtColor(img,cv.COLOR_BGR2GRAY)
cv.imshow('gray person',gray)

haar_cascade= cv.CascadeClassifier('haar_face.xml')


faces_rect = haar_cascade.detectMultiScale(gray,scaleFactor=1.1,minNeighbors=1)

print(f'Number of faces found = {len(faces_rect)}')

identifiedFace= img.copy()
for (x,y,w,h) in faces_rect:
    cv.rectangle(identifiedFace,(x,y),(x+w,y+h),(0,255,0),thickness=2)
cv.imshow('identifiedFace',identifiedFace)

cv.waitKey(0)
