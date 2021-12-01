import cv2 as cv

capture= cv.VideoCapture('./Resources/Videos/dog.mp4')

def rescaleFrame(frame,scale=0.75):
    #For imgs, videos, live videos
    width=int(frame.shape[1]*scale)
    height=int(frame.shape[0]*scale)
    dimensions=(width,height)
    return cv.resize(frame,dimensions,interpolation=cv.INTER_AREA)

def changeRes(width,height):
    # Live videos
    capture.set(3,width)
    capture.set(4,height)

# img = cv.imread('Resources/Photos/cat_large.jpg')
# resized_img = rescaleFrame(img,0.2)
# cv.imshow('Cat',img)
# cv.imshow('Cat',resized_img)




while True:
    isTrue,frame = capture.read()
    frame_resized=rescaleFrame(frame)
    cv.imshow('Video',frame)
    cv.imshow('Video Resized',frame_resized)
    if cv.waitKey(20) & 0xFF == ord('d'):
        break
    
capture.release()
cv.destroyAllWindows()

# cv.waitKey(0)