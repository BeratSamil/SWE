import matplotlib.pyplot as plt
import random as rnd


x = list(range(1, 13))
y = [rnd.randint(0, 100) for _ in range(12)]
plt.bar(x, y)
plt.xlabel('Index')
plt.ylabel('Random Value')
plt.title('12 Random Bars (0-100)')

plt.xticks(x)
plt.show()