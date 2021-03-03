kredi1 = "Hızlı Kredi"
kredi2 = "Maaşını Halkbaktan Alanlara Özel"
kredi3 = "Mutlu Emekli İhtiyaç Kredisi"
#4. tür kredi eklemek için aşağıdaki eklenir
kredi4 = "Özel Sektör"

print(kredi1)
print(kredi2)
print(kredi3)
#4. tür kredi eklemek için aşağıdaki eklenir
print(kredi4)

#yukarıdaki yöntem yerine aşağıdaki kullanılır
#list (array) tipi kullanılır
krediler = ["Hızlı Kredi", "Maaşını Halkbaktan Alanlara Özel", "Mutlu Emekli İhtiyaç Kredisi", "Özel Sektör"]
#aşağıdaki döngü krediler dizisinin eleman sayısı kadar dönmeli
#4. tür kredi eklemek için sadece arraye eklenir
for kredi in krediler:
    print(kredi)

