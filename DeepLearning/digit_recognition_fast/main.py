import pandas as pd
import tensorflow as tf
import numpy as np
import matplotlib.pyplot as plt
from tensorflow.python.keras.activations import softmax
from tensorflow.python.keras.metrics import accuracy
from tensorflow.python.keras import activations
import cv2 as cv


data = tf.keras.datasets.mnist

(x_train, y_train), (x_test, y_test) = data.load_data()

x_train = tf.keras.utils.normalize(x_train, axis=1)
x_test = tf.keras.utils.normalize(x_test, axis=1)
model = tf.keras.models.Sequential()
model.add(tf.keras.layers.Flatten(input_shape= (28,28)))
model.add(tf.keras.layers.Dense(units=128,activation = tf.nn.relu))
model.add(tf.keras.layers.Dense(units=128,activation = tf.nn.relu))
model.add(tf.keras.layers.Dense(units=10,activation = tf.nn.softmax))

model.compile(optimizer ='adam', loss= 'sparse_categorical_crossentropy', metrics= ['accuracy'])
model.fit(x_train, y_train,epochs = 3)
loss, accuracy = model.evaluate(x_test,y_test)
print(accuracy)
print(loss)
model.save('saved_model')

for x in range(1,6):
    img = cv.imread(f'my_samples/{x}.png')[:,:,0]
    img = np.invert(np.array([img]))
    prediction =  model.predict(img)
    print("--------------------------")
    print(f'The predicted output for {x}.png is {np.argmax(prediction)} ')
    print("--------------------------")
    plt.imshow(img[0], cmap = plt.cm.binary)
    plt.show()