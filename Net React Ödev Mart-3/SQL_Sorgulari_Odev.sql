
--1. Books tablosundaki tüm kitaplar
SELECT * FROM Books;

-- 2. 'Bilgisayar Bilimleri' kategorisindeki kitaplar
SELECT b.*
FROM Books b
JOIN Categories c ON b.CategoryID = c.CategoryID
WHERE c.CategoryName = 'Bilgisayar Bilimleri';

-- 3. 2020 ve sonrasında yayımlanan kitaplar
SELECT * FROM Books
WHERE PublicationYear >= 2020;

-- 4. Kitap adı ve ait olduğu kategori
SELECT b.Title, c.CategoryName
FROM Books b
JOIN Categories c ON b.CategoryID = c.CategoryID;

-- 5. Kitap alan öğrencilerin adı, soyadı ve kitap adı
SELECT u.FirstName, u.LastName, b.Title
FROM Borrowings br
JOIN Users u ON br.UserID = u.UserID
JOIN Books b ON br.BookID = b.BookID;

-- 6. Kitap ve yazarı ile yayın yılı
SELECT b.Title, a.AuthorName, b.PublicationYear
FROM Books b
JOIN Authors a ON b.AuthorID = a.AuthorID;

-- 7. Hangi kullanıcı hangi kitabı ne zaman almış
SELECT u.FirstName, u.LastName, b.Title, br.BorrowDate
FROM Borrowings br
JOIN Users u ON br.UserID = u.UserID
JOIN Books b ON br.BookID = b.BookID;

-- 8. Geri dönüş tarihi boş olan kitaplar ve kullanıcılar
SELECT u.FirstName, u.LastName, b.Title
FROM Borrowings br
JOIN Users u ON br.UserID = u.UserID
JOIN Books b ON br.BookID = b.BookID
WHERE br.ReturnDate IS NULL;

-- 9. Her kategoriye ait kitap sayısı
SELECT c.CategoryName, COUNT(*) AS KitapSayisi
FROM Books b
JOIN Categories c ON b.CategoryID = c.CategoryID
GROUP BY c.CategoryName;

-- 10. En çok kitap ödünç alan kullanıcılar (en fazla borç alandan az borç alana)
SELECT u.FirstName, u.LastName, COUNT(*) AS OduncSayisi
FROM Borrowings br
JOIN Users u ON br.UserID = u.UserID
GROUP BY u.FirstName, u.LastName
ORDER BY COUNT(*) ASC;
