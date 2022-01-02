import cv2 as cv
import matplotlib.pyplot as plt
import numpy as np
img = cv.imread('../Resources/Photos/cats.jpg')
cv.imshow('cats',img)
blank = np.zeros(img.shape[:2],dtype='uint8')
# circle= cv.circle(blank,(img.shape[1]//2,img.shape[0]//2),100,255,-1)
# gray = cv.cvtColor(img,cv.COLOR_RGB2GRAY)
# mask=cv.bitwise_and(img,img,mask=circle)

# cv.imshow('gray',gray)


# gray_hist=  cv.calcHist([gray],[0],mask,[256],[0,256]) 
# plt.figure()
# plt.title('Grayscale histogram')
# plt.xlabel('bins')
# plt.ylabel('# of pixels')
# plt.plot(gray_hist)   
# plt.xlim([0,256])
# plt.show()

#  #color histogram
mask= cv.circle(blank,(img.shape[1]//2,img.shape[0]//2),100,255,-1)
masked=cv.bitwise_and(img,img,mask=mask)

plt.figure()
plt.title('Color histogram')
plt.xlabel('Bins')
plt.ylabel('# of pixels')
colors = ('b','g','r')
for i,col in enumerate(colors):
    # print(i,col)
    hist= cv.calcHist([img],[i],mask,[256],[0,256])
    plt.plot(hist,color=col)
    plt.xlim([0,256])
plt.show()

cv.waitKey(0)