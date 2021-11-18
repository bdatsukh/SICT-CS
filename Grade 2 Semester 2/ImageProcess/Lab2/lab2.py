"""
from PIL import Image
im = Image.open('image1.jpg').convert('L')
im.save('ByPython.jpg')
"""

#Thumbnail үүсгэх
from PIL import Image
im = Image.open('image1.jpg')
im.thumbnail((128, 128))
im.save('thumbnail.jpg')

"""
from PIL import Image
im = Image.open('image1.jpg')
box = (1800, 1500, 2500, 2000)
region = im.crop(box)
region = region.transpose(Image.ROTATE_180)
im.paste(region, box)
im.save('crop_rotate.jpg')
"""