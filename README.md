# Chain of Responsibility

Sorumluluk Zinciri -Chain of Responsibility (CoR)- tasarım deseni (behavioral design patterns) davranışsal tasarım desenlerinden biridir.

Davranışlar tasarım desenleri; yazılım bileşenlerinin nasıl etkileşimde bulunacağını ve nasıl işbirliği yapacaklarını yöneten şablonlardır. Tasarım deseni olmaları hasebiyle tekrar kullanılabilirlik sağlamış olur ve kodu isterlerin değişimine direnç göstermeyen esnek yapılı bir hale getirir.

# Gerçek Hayattan Bir Örnek
Gerçek hayatta bu prensibin karşımıza çıktığı yerler var mı?

Müşteri hizmetlerini aradığınızda sizi işlemleri sıralayarak ve sesli yanıt veya tuşlama ile ilgili kişiye ulaştırdığı senaryoda sorumluluk prensibi benzeri bir yapı işliyor. Çünkü sırayla kontroller sağlanarak eğer zincirin şuanki halkası isteğinizi karşılayabiliyorsa ona yönlendiriliyor eğer karşılayamıyorsa bir sonraki halkaya aktarılıyorsunuz ta ki isteğinizi karşılayabilecek yetkiliye ulaşana kadar.

