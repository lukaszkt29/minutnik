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