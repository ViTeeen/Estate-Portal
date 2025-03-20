# Estate-Portal - Konfiguracja

Aby poprawnie skonfigurować aplikację, wykonaj poniższe kroki:

## 1. Uzupełnij plik `appsettings.json` swoimi danymi. Aplikacja używa tego pliku do przechowywania poufnych danych, takich jak dane logowania do bazy danych, SMTP i autoryzacji Google.
Otwórz plik `appsettings.json` i wypełnij następujące sekcje:

### ConnectionStrings
Ustaw dane połączenia z Twoją bazą danych (Używamy XAMPP oraz MariaDB):
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=mybase;User=root;Password=YOUR_PASSWORD;"
}
```

### SmtpSettings
Skonfiguruj dane dla serwera SMTP (np. Mailtrap):
```json
"SmtpSettings": {
  "Host": "sandbox.smtp.mailtrap.io",
  "Port": 587,
  "SenderName": "Estate Portal",
  "SenderEmail": "YOUR_EMAIL",
  "Username": "YOUR_USERNAME",
  "Password": "YOUR_PASSWORD",
  "EnableSsl": true
}
```

### Authentication (Google)
Dodaj dane autoryzacji dla Google:
```json
"Authentication": {
  "Google": {
    "ClientId": "YOUR_CLIENT_ID",
    "ClientSecret": "YOUR_CLIENT_SECRET"
  }
}
```

## 2. Aby zintegrować aplikację z Google Maps i funkcją automatycznego uzupełniania nazw miejscowości, dodaj klucz API w pliku `AddAnnouncement.cshtml`.
```html
<script src="https://maps.googleapis.com/maps/api/js?key=YOUR_KEY&libraries=places"></script>
```

Gotowe! 🎉 Aplikacja powinna teraz działać z Twoimi ustawieniami.
