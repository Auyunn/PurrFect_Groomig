CREATE TABLE Booking (
    BookingID INT PRIMARY KEY IDENTITY(1,1),

    Customer VARCHAR(100),
    Package VARCHAR(100),
    Groomer VARCHAR(100),

    BookingDate DATE,
    TimeSlot VARCHAR(50),

    -- ✅ Add-On dari AddOnForm
    HairCut VARCHAR(100),
    Shampoo VARCHAR(100),
    FleaTreatment VARCHAR(100),
    NailClip VARCHAR(50),
    TeethCleaning VARCHAR(50),

    -- ✅ Total price dari calculation
    TotalPrice DECIMAL(10,2)
);
INSERT INTO Booking
(Customer, Package, Groomer, BookingDate, TimeSlot,
 HairCut, Shampoo, FleaTreatment, NailClip, TeethCleaning, TotalPrice)

VALUES
('Amirah', 'Basic', 'Ali', '2026-06-21', '10AM',
 'Korean Haircut', 'Aloe Vera Shampoo', 'None', 'Yes', 'No', 35.00),

('Amir', 'Premium', 'John', '2026-06-22', '2PM',
 'Lion Cut', 'Vegan Shampoo', 'Oral Medication', 'No', 'Yes', 60.00);
 SELECT * FROM Booking;