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

plt.subplot(1, 2, 1), plt.imshow(img), plt.title('original'), plt.axis('off')
plt.subplot(1, 2, 2), plt.imshow(gauss_noise), plt.title('noise'), plt.axis('off')
plt.show()

plt.subplot(1, 2, 1), plt.imshow(img_noise), plt.title('img with noise'), plt.axis('off')
plt.subplot(1, 2, 2), plt.imshow(img_after_gauss_blur), plt.title('img after gauss blur'), plt.axis('off')
plt.show()

plt.subplot(1, 2, 1), plt.imshow(img_after_median_blur), plt.title('img after median blur'), plt.axis('off')
plt.subplot(1, 2, 2), plt.imshow(img_after_bilateral_blur), plt.title('img after bilateral blur'), plt.axis('off')
plt.show()
