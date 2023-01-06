## DEPENDENCY INJECTION NEDİR?
Dependency Injection uygulamalarımızı bağımlılıktan kurtarma pensiplerinden bir tanesidir. Uygulamamız nesneye bağımlı olursa bu nesne dışında başka bir nesne kullanmak 
istediğimizde uygulamamızın bir çok yerinde değişiklik yapmak zorunda kalırız.
## Inversion Of Control (IOC) NEDİR?
IoC(Inversion Of Control), uygulamanın yaşam döngüsü boyunca birbirine bağımlılığı az (loose coupling) olan nesneler oluşturmayı amaçlayan bir yazılım geliştirme prensibidir. Nesnelerin yaşam döngüsünden sorumludur, yönetimini sağlar. 
## ADIM ADIM IOC
1.Tigly Couple Class</br>
2.Factory Pattern ile IOC Iplementasyon</br>
3.Abstraction oluşturarak DIP Iplementasyon</br>
4.Dependency Injection(DI) Iplementasyon</br>
5.IOC Container Kullanma</br>
6.Losely Couple Class</br>
## Oluşturduğumuz Nesnelerin Yaşam Sürelerinin Durumları
<strong>Singelton</strong>: Uygulama ilk başlatıldığında ilgili nesneyi bir kere oluşturur ve yapılan istek vs. farketmeksizin bu oluşturduğu nesneyi kullanır. <br/>
<strong>Scoped</strong>: Uygulama her bir istekte nesneyi instance eder. İstek bitene kadar tekrardan oluşmaz. <br/>
<strong>Transient</strong>: Nesneyi her çağırdığımızdaa yeni bir instance oluşur.

