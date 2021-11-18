import cv2
import numpy as np
import matplotlib.pyplot as plt


img = cv2.imread('opencv_logo.png')
gauss_noise = np.random.normal(0, 1, img.size)
gauss_noise = gauss_noise.reshape(img.shape[0], img.shape[1], img.shape[2]).astype('uint8')

img_noise = cv2.add(img, gauss_noise)
img_after_gauss_blur = cv2.GaussianBlur(img, (3, 3), 0)
img_after_median_blur = cv2.medianBlur(img, 3)
img_after_bilateral_blur = cv2.bilateralFilter(img, 3, 75, 75)


def show(img, img1, name, name1):
    plt.subplot(1, 2, 1)
    plt.imshow(img)
    plt.title(name)
    plt.axis('off')
    plt.subplot(1, 2, 2)
    plt.imshow(img1)
    plt.title(name1)
    plt.axis('off')
    plt.show()

show(img, gauss_noise, 'original', 'noise')
show(img_noise, img_after_gauss_blur, 'img with noise', 'img after gauss blur')
show(img_after_median_blur, img_after_bilateral_blur, 'img afzter median blur', 'img after bilateral blur')