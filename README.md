# Budzet_Domowy
Projekt aplikacji budżetu domowego w której śledzi się przychody i wydatki, stworzone w języku C# z użyciem .NET i WinForms.
![image](https://github.com/user-attachments/assets/914d780d-0722-44cb-9bc0-3a029f29d754)

# Funkcje aplikacji
1. Dodawanie rekordów przychodów i wydatków.
2. Zapisywanie rekordów do pliku
3. Edycja i usuwanie istniejących rekordów
4. Obliczanie aktualnie dostępnych środków
5. Wyświetlanie danych w tabeli
# Wymagania
1..NET 6.0 lub nowszy

2.Microsoft Visual Studio 2022

3.System operacyjny Windows
# Instalacja
1. Należy pobrać kod źródłowy
2. Skompilować i uruchomić aplikację
# OOP
1. Klasy
Form1-jest główną formą aplikacji, odpowiada za inicjalizacje komponentów i obługę przycisków.
Form2-służy do wprowadzania danych (przychodów i wydatków) i ich zapisywania do pliku. Obsługuje walidację danych oraz zapis do pliku tekstowego.
Form4-jest używana do wyświetlania i edytowania danych zapisanych w pliku. Obsługuje ładowanie i usuwanie danych
Hermetyzacja
![image](https://github.com/user-attachments/assets/f951f4ad-fae5-4c93-9bd1-54b0c0e251ba)

![image](https://github.com/user-attachments/assets/54851ff2-d7ed-4295-8032-c875c419d843)

Jest dostępna tylko wewnątrz Form4,co zabezpiecza sposób wczytywania danych z pliku w obydwu przypadkach
Polimorfizm
Przykładem są metody button1_Click występujące w Form1,Form2,Form4-mają tę samą nazwę, ale różnią się implementacją, co jest przejawem polimorfizmu.
Na przykład 
button1_Click w Form2
![image](https://github.com/user-attachments/assets/0edebb89-fcf2-4a01-b8f3-8c6c24db548a)

button1_Click w Form1

![image](https://github.com/user-attachments/assets/cd3edd81-f1c0-433a-8b34-6fc7130a106a)




