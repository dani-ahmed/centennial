import numpy as np
import matplotlib.pyplot as plt

# generate sample of 100 numbers between -100 and 100
x = np.random.uniform(-100,100,100)

# set seed to 72
np.random.seed(72)

# create y set
y1 = (12 * x) - 4

#plot graph with titles and axis
plt.scatter(x, y1, alpha = 0.5)
plt.xlabel("x-value")
plt.ylabel("y = (12 * x) - 4")
plt.title("X vs Y")

#calculate standard deviation and mean of x
sum = 0
for num in x:
    sum += num
mean = sum / len(x)
sd = np.std(x)

#draw random sample from gaussian distribution, using mean and standard deviation
noise = np.random.normal(mean, sd)

#create second set of y values with noise
y2 = ((12 * x) - 4) + noise

#plot graph with noise
plt.scatter(x, y2, alpha = 0.5)
plt.xlabel("x-value")
plt.ylabel("y = ((12 * x) - 4) + noise")
plt.title("X vs Y (noise injected)")