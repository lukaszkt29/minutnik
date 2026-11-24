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
