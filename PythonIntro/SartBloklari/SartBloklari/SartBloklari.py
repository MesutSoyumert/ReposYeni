dolarDun = 7.35
dolarBugun = 7.25

#syntax
#indentation
# if - else aynı operand veya değişkenin iki durumu varsa kullanılır
# boolean değişkenlerin kontrolü en iyi örnek olabilir true-false
if dolarDun>dolarBugun:
    print("Azalış oku")
elif dolarDun<dolarBugun:
    print("Artış oku")
else:
    print("Değişmedi oku")

#yukarıdaki blok aşağıdaki gibi farklı yazılabilir
#okuması rahat ama gereksiz bir if kontrolü yapılıyor
if dolarDun>dolarBugun:
    print("Azalış oku")
elif dolarDun<dolarBugun:
    print("Artış oku")
elif dolarDun==dolarBugun:
    print("Değişmedi oku")