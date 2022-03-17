import tensorflow as tf
import matplotlib.pyplot as plt
import numpy as np
import cv2 as cv

from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Dense, Dropout, Activation, Flatten, Conv2D, MaxPooling2D
IMG_SIZE = 28


def checkDataSet():
    # #check the first image in dataset
    plt.imshow(x_train[0])
    plt.show()
    plt.imshow(x_train[0], cmap=plt.cm.binary)
    plt.show()
    print(x_train[0])  # before normalization
    pass


def trainModel(x_trainr, y_train):
    # Create neural network
    model = Sequential()

    # First Convolution Layer
    model.add(Conv2D(64, (3, 3), input_shape=x_trainr.shape[1:]))
    model.add(Activation("relu"))  # remove <0 keep only >0
    model.add(MaxPooling2D(pool_size=(2, 2)))

    # Second Convolution Layer
    model.add(Conv2D(64, (3, 3), input_shape=x_trainr.shape[1:]))
    model.add(Activation("relu"))
    model.add(MaxPooling2D(pool_size=(2, 2)))

    # Third Convolution Layer
    model.add(Conv2D(64, (3, 3), input_shape=x_trainr.shape[1:]))
    model.add(Activation("relu"))
    model.add(MaxPooling2D(pool_size=(2, 2)))

    # Fully Conected Layer #1
    model.add(Flatten())
    model.add(Dense(64))
    model.add(Activation("relu"))

    # Fully Conected Layer #2
    model.add(Dense(32))
    model.add(Activation("relu"))

    # Fully Conected Layer #3
    model.add(Dense(10))  # must be equal to 10
    model.add(Activation("softmax"))  # class probabilities

    # print(model.summary())
    # print("total training samples:",len(x_trainr))
    #Compile it.
    model.compile(loss="sparse_categorical_crossentropy",
                  optimizer="adam", metrics=['accuracy'])
    model.fit(x_trainr, y_train, epochs=5,
              validation_split=0.3)  # training model
    model.save('saved_model')
    return model



if __name__ == '__main__':
    mnist = tf.keras.datasets.mnist
    (x_train, y_train), (x_test, y_test) = mnist.load_data()
    # checkDataSet()
    x_train = tf.keras.utils.normalize(x_train, axis=1)
    x_test = tf.keras.utils.normalize(x_test, axis=1)
    # plt.imshow(x_train[0], cmap = plt.cm.binary)
    # plt.show()
    x_trainr = np.array(x_train).reshape(-1, IMG_SIZE, IMG_SIZE, 1)
    x_testr = np.array(x_test).reshape(-1, IMG_SIZE, IMG_SIZE, 1)
    print("Training/ Testing samples dimensions:",
          x_trainr.shape, x_testr.shape)

    # model = trainModel(x_trainr,y_train)
    model = tf.keras.models.load_model('saved_model')
    # test_loss, test_acc = model.evaluate(x_testr,y_test)
    # print(f"You lost {int(test_loss*  10000)} from 10.000 tests")
    # print(f"Validation accuracy on 10.000 tests is",test_acc)
    # predictions = model.predict([x_testr])
    # print(np.argmax(predictions[0]))
    # plt.imshow(x_test[0])
    # plt.show()
    for img_index in range(1,6): #max 6
        img = cv.imread(f'my_samples/{img_index}.png')
        gray = cv.cvtColor(img,cv.COLOR_BGR2GRAY)
        resized = cv.resize(gray,(28,28),interpolation = cv.INTER_AREA)
        resized = np.invert(np.array([resized]))
        newimg = tf.keras.utils.normalize(resized,axis=1)
        newimg = np.array(newimg).reshape(-1,IMG_SIZE,IMG_SIZE,1)
        predictions = model.predict(newimg)
        print(np.argmax(predictions), " ")
        # plt.imshow(gray)
        # plt.show()