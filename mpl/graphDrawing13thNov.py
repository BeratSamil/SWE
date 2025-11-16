import numpy as np
import matplotlib.pyplot as plt

# x değerlerini belirle (örneğin -5 ile 5 arası)
x = np.linspace(-1, 10, 200)

# f(x) fonksiyonunu tanımla
# y = x*2 - 2

y1=np.cos(x)
y2=np.sin(x)

# Grafiği çiz. Hocaya göre en önemlisi imiş.
plt.plot(x, y1, label="sin",color='red')
plt.plot(x, y2, label="cos",color='springgreen')


# Eksen çizgileri
plt.axhline(0, color='hotpink', linewidth=0.8)
plt.axvline(0, color='green', linewidth=0.8)

# Başlık ve etiketler
plt.title("test Graph")
plt.xlabel("x")
plt.ylabel("f(x)")
plt.legend()
plt.grid(True)

# Göster
plt.show()
