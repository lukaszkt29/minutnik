Zbuduj minutnik w tym projekcie Avalonia. Ma odmierzać 25 minut pracy,
potem 5 minut przerwy, i liczyć skończone cykle. Obie długości mają być do
zmiany w oknie. Jeden przycisk start/pauza, drugi reset. Czas widoczny jako
mm:ss, licznik cykli widoczny obok. Po skończonej pracy przerwa ma ruszyć
sama. Interfejs po polsku, nazwy w kodzie po angielsku, bez dodatkowych
bibliotek. Cała logika wprost w pliku MainWindow.axaml.cs, bez osobnych
klas pośredniczących.

## Wyniki lekcji o kontekście

Pomiar z dnia 2026-11-24, narzędzie: `tiktoken` (`cl100k_base`).

- pierwsza polska wiadomość do agenta: 163 tokeny;
- angielska wersja tej samej wiadomości: 118 tokenów;
- okno kontekstu modelu `gpt-5.6-luna`: nie odnaleziono publicznej liczby;
- maksymalna długość odpowiedzi modelu `gpt-5.6-luna`: nie odnaleziono publicznej liczby.

Brak danych nie został zastąpiony zgadywaniem.

### Próba separatora dziesiętnego

Przy bieżącej kulturze Windows `pl-PL` zapis `25,5` jest interpretowany jako
liczba dziesiętna 25,5 i powinien zostać przyjęty przez pole. Zapis `25.5`
jest interpretowany jako niepoprawny dla tej kultury i nie powinien zostać
przyjęty.

## Rozbiór promptu z pokazu

- „Zbuduj minutnik w tym projekcie Avalonia.” — **CO** ma powstać oraz **JAK**
  wskazany jest projekt i technologia.
- „Ma odmierzać 25 minut pracy” — **CO** ma robić.
- „potem 5 minut przerwy, i liczyć skończone cykle.” — **CO** ma robić.
- „Obie długości mają być do zmiany w oknie.” — **CO** ma być możliwe
  podczas używania aplikacji.
- „Jeden przycisk start/pauza, drugi reset.” — **CO** ma być widoczne i działać.
- „Czas widoczny jako mm:ss, licznik cykli widoczny obok.” — **PO CZYM POZNAĆ**
  gotowość interfejsu.
- „Po skończonej pracy przerwa ma ruszyć sama.” — **PO CZYM POZNAĆ**
  poprawne działanie po przejściu faz.
- „Interfejs po polsku, nazwy w kodzie po angielsku, bez dodatkowych bibliotek.”
  — **JAK** ma być napisany i zorganizowany wynik.
- „Cała logika wprost w pliku MainWindow.axaml.cs, bez osobnych klas pośredniczących.”
  — **JAK** ma być ułożony kod.

Liczba instrukcji **CO**: 6; liczba instrukcji **JAK**: 3; liczba instrukcji
**PO CZYM POZNAĆ**: 2. Najmniej jest instrukcji typu „PO CZYM POZNAĆ”.

## Reset w środku przerwy

Dzisiaj program po naciśnięciu Resetu w środku przerwy zatrzymuje licznik,
czyści historię i liczbę ukończonych cykli do zera, przechodzi z powrotem do
fazy pracy i ustawia czas na pełną długość ustawioną dla pracy. To decyzja
modelu: prompt nie określił tego przypadku, a model sam dobrał takie zachowanie.

## Co spisujesz dzisiaj

Dzisiejsza praca obejmuje specyfikację po fakcie, jednozdaniowy dziennik
weryfikacji uruchomionej aplikacji oraz rozbiór promptu z pokazów.