

namespace GetterSetterElevatorTest
{
    internal class Program
    {

        private static readonly GetterSetterElevator _elevator = new GetterSetterElevator();

        static void Main(string[] args)
        {
            _elevator.setDoorOpen(true);     // Kapı açılır
            _elevator.setDoorOpen(false);    // Kapı kapanır
            _elevator.setCurrentFloor(_elevator.getCurrentFloor() + 1);  // Bulunulan kattan bir üst kata asansör çıkar
            _elevator.setCurrentFloor(7); // Asansör 7. kata çıkartılmak istenir fakat bina 5 katlı iş kuralı burada da bulunmuyor.
            _elevator.setDoorOpen(true);
            _elevator.setCurrentFloor(_elevator.getCurrentFloor() - 1); // Kapılar açıkken başka bir kata geçiş sağlanmaya çalışılır
            _elevator.setDoorOpen(false);
            _elevator.setCurrentFloor(_elevator.getCurrentFloor() - 1); // En üst veya en alt katta olup olmama durumu sorgulanmadan ilerlenmek istenir


            /*
                DataOnlyElevator projesinde bir takım geliştirmeler yaptık biraz iyileştirmek adına veri saklama sürecisi biraz değiştirdik burada.
                Tanım properties'lere atamaları get/set metotlar yoluyla gerçekleştirdik.
                Fakat halen yanlış veya eksik davranışlar bulunuyor.
                Burada da davranış sağlanmadığı için tüm davranıştan program.cs sorumludur.
                İstemci sadece veri alış verişi yapmakta dolayısıyla yanlış gönderilen bir değer ile birlikte sistemin kırılganlığı çok yüksek olacaktır.                         
             */
        }      
    }
}