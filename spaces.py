import cv2 as cv
import matplotlib.pyplot as plt
img = cv.imread('Resources/Photos/group 1.jpg')

# cv.imshow("img",img)

# plt.imshow(img)
# plt.show()

gray= cv.cvtColor(img,cv.COLOR_BGR2GRAY)
# cv.imshow("gray",gray)


#BGR TO HSV
hsv= cv.cvtColor(img,cv.COLOR_BGR2HSV)
# cv.imshow("hsv",hsv)

#BGR TO Lab
lab= cv.cvtColor(img,cv.COLOR_BGR2Lab)
# cv.imshow("lab",lab)

#BGR to rgb
rbg= cv.cvtColor(img,cv.COLOR_BGR2RGB)
# plt.imshow(rbg)
# plt.show()


# HSV TO BGR
hsv_bgr= cv.cvtColor(hsv,cv.COLOR_HSV2BGR)
# cv.imshow("hsv_bgr",hsv_bgr)

# lab TO BGR
lab_bgr= cv.cvtColor(lab,cv.COLOR_LAB2BGR)
cv.imshow("hsv_bgr",lab_bgr)

cv.waitKey(0)