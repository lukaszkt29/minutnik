# Co robi

Minutnik ma odmierzać 25 minut pracy i 5 minut przerwy. Długości obu etapów
można zmienić w oknie. Ma mieć jeden przycisk Start/Pauza i jeden przycisk
Reset. Pozostający czas ma być pokazywany w formacie mm:ss, a obok licznik
ukończonych cykli. Po zakończeniu pracy przerwa ma uruchamiać się automatycznie.

# Czego nie robi

Nie zapisuje ustawień ani stanu po zamknięciu programu. Nie uruchamia osobnego
procesu w tle po zamknięciu okna i nie odtwarza historii z poprzedniej sesji.
Nie dodaje osobnych klas pośredniczących ani dodatkowych bibliotek. Nie ma
opisanej osobno funkcji ustawiania innych jednostek czasu niż minuta.

# Kiedy ..., to ...

- Kiedy naciśniesz Start, to czas zaczyna odliczać sekundy.
- Kiedy naciśniesz Pauza, to odliczanie zatrzymuje się bez utraty pozostałego czasu.
- Kiedy naciśniesz Reset, to czas wraca do ustawionej długości pracy i licznik
  cykli zeruje się.
- Kiedy skończy się praca, to licznik cykli wzrasta o jeden i zaczyna się przerwa.
- Kiedy skończy się przerwa, to aplikacja wraca do pracy i przestaje odliczać.

# Do ustalenia

- Czy Reset podczas przerwy ma zmniejszać też licznik cykli i kończyć fazę przerwy.

# Porównanie z siedmioma zasadami

Po porównaniu z siedmioma zasadami odtworzyłem 7 z 7: nazwy i interfejs po polsku
lub angielsku odpowiednio, osobny ekran jako wspólna para plików nie dotyczy
wyłącznie tego jednego okna, brak dodatkowych bibliotek, wyłącznie bieżący stan
bez pliku danych dla danych, UTF-8, brak zmian poza zadaniem i krótkie metody.
Program działa także w sytuacji, o której żadna z zasad nie mówiła: po naciśnięciu
Resetu w środku przerwy ustawia fazę na pracę, liczbę cykli na 0 i czas na pełną
długość pracy.
