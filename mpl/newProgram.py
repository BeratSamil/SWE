s='''Unutma yetisini kaybetmenin siyah mermerden yapılmış kaskatı bir levha haline getirdiği hayatım bundan otuz küsur yıl önce altüst oldu. Bir gece sabaha karşı bir saatte annemin uyurgezer olduğunu fark ettim. Ama hayatım annem uyurgezer olduğu için değil, annemin uyur halde gezerken bana söylediği şey yüzünden altüst oldu. Annem o gece benliğime öyle bir darbe indirdi ki, bir daha yaşadığım hiçbir şeyi unutamadım.
Annemin annesinden nefret etmesi gibi, ben de annemden nefret mi ediyorum, bu yüzden mi E.’den kopamıyorum, bağımsız bir Şehnaz olamıyorum diye kendime soruyordum. Cevaplarından korktuğum sorulardı bunlar.
Unutamayan bir belleğin kişisel muhasebesi, hayata rengini veren otuz yıllık güçlü bir aşkın anatomisi ve bir ülkenin toplumsal panoraması.
Annesinin uyurgezerliği bilinçdışının labirentlerinde kaybolduğu sanılan aile sırlarını açığa çıkarırken buna tanık olan Şehnaz’ın belleği unutma yetisini kaybeder. Öğrendiği sırlar sadece aile sırları değildir, Osmanlı’dan günümüze uzanan toplumsal ve trajik bir kadınlık durumudur. Ekonomi profesörü Şehnaz kadınların yüzyıllardır süren yok-hayatlarını sorgularken erkeklerin hayattan erken çekildiği kadıncıl ailesinin var olma sürecini bir akademisyen gözüyle ele alır. Kişisel muhasebesini yaparken toplumsal normlara uymayan otuz yıllık aşkının zehirli yanlarıyla yüzleşir, bu sırada aklında bir başka kadın, büyük aşkı E.’nin karısı Eyşan vardır.
Annemin Uyurgezer Geceleri, bireysel hatıraların nasıl toplumsal hafızaya dönüştüğünü güçlü bir edebiyat diliyle sorgularken okurları bu ülkede kadın olmanın düşünmekten kaçındığımız gerçeğini de düşünmeye zorluyor.'''
sayi=s.count('a')
ctr=0
len(s)
for c in s:
    if (c=="a"):
        ctr+=1
    

print(ctr)
print(ctr/len(s),"frekans")