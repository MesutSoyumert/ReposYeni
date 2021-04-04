
sayi1=110
sayi2=110
sayi3=110
enBuyukSayi=0
enKucukSayi=0
esittirMesaj=''
esitSayilarVar=0

if sayi1==sayi2 and sayi2==sayi3:
  esittirMesaj="Üç sayı da birbirine eşittir"
  esitSayilarVar=1
elif sayi1==sayi2:
  esittirMesaj="Sayı 1 ile Sayı 2 birbirine eşittir"
  esitSayilarVar=1
elif sayi1==sayi3:
  esittirMesaj="Sayı 1 ile Sayı 3 birbirine eşittir"
  esitSayilarVar=1
elif sayi2==sayi3:
  esittirMesaj="Sayı 2 ile Sayı 3 birbirine eşittir"
  esitSayilarVar=1

if esitSayilarVar==1:
  print (esittirMesaj)


if sayi1>=sayi2 and sayi1>=sayi3:
  enBuyukSayi=sayi1
elif sayi2>=sayi1 and sayi2>=sayi3:
  enBuyukSayi=sayi2
elif sayi3>=sayi1 and sayi3>=sayi2:
  enBuyukSayi=sayi3

print("En Büyük Sayı = ",enBuyukSayi)

if sayi1<=sayi2 and sayi1<=sayi3:
  enKucukSayi=sayi1
elif sayi2<=sayi1 and sayi2<=sayi3:
  enKucukSayi=sayi2
elif sayi3<=sayi1 and sayi3<=sayi2:
  enKucukSayi=sayi2

print("En Küçük Sayı = ",enKucukSayi)



  