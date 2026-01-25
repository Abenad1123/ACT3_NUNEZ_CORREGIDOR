Public Class var
    ' ===== FICTION =====
    Public Shared Fiction() As String = {
        "Charlotte’s Web - E.B. White",
        "Harry Potter and the Sorcerer’s Stone - J.K. Rowling",
        "The Lion, the Witch and the Wardrobe - C.S. Lewis",
        "Diary of a Wimpy Kid - Jeff Kinney"
    }

    ' ===== NON-FICTION =====
    Public Shared NonFiction() As String = {
        "National Geographic Kids Encyclopedia",
        "Who Was Abraham Lincoln? - Janet B. Pascal",
        "A Brief History of Time (Young Readers) - Stephen Hawking",
        "The Diary of a Young Girl - Anne Frank"
    }

    ' ===== FANTASY =====
    Public Shared Fantasy() As String = {
        "Percy Jackson and the Lightning Thief - Rick Riordan",
        "Harry Potter Series - J.K. Rowling",
        "The Hobbit - J.R.R. Tolkien",
        "Artemis Fowl - Eoin Colfer"
    }

    ' ===== MYSTERY =====
    Public Shared Mystery() As String = {
        "Nancy Drew - Carolyn Keene",
        "The Hardy Boys - Franklin W. Dixon",
        "Encyclopedia Brown - Donald J. Sobol"
    }

    ' ===== SCIENCE FICTION =====
    Public Shared ScienceFiction() As String = {
        "A Wrinkle in Time - Madeleine L’Engle",
        "Ender’s Game - Orson Scott Card",
        "The Giver - Lois Lowry"
    }

    ' ===============================
    ' STUDENT INFORMATION
    ' ===============================
    Public Shared full_name As String = "None"
    Public Shared last_name As String = "None"
    Public Shared gender As String = "None"
    Public Shared date_of_birth As String = "None"
    Public Shared place_of_birth As String = "None"
    Public Shared address As String = "None"

    ' ===============================
    ' PARENT / GUARDIAN INFORMATION
    ' ===============================
    Public Shared parent_name As String = "None"
    Public Shared parent_phone_num As String = "None"
    Public Shared parent_email_add As String = "None"

    ' ===============================
    ' ENROLLMENT DETAILS
    ' ===============================
    Public Shared enrollment_type As String = "None"

    ' ===============================
    ' STANDARD FEES
    ' ===============================
    Public Shared tuition_fee() As Integer = {140143, 132210, 132210}
    Public Shared miscellaneous_fee() As Integer = {5150, 3817, 2710}
    Public Shared books_fee As Integer = 11500

    ' ===============================
    ' TRANSPORTATION FEES
    ' ===============================
    Public Shared school_bus_fee_yearly As Integer = 80000
    Public Shared shuttle_fee_yearly As Integer = 50000
    Public Shared transport_type As String = "None"
    Public Shared transport_total As Integer = 0

    ' ===============================
    ' UNIFORMS
    ' ===============================
    Public Shared regUni_fullSet() As Integer = {800, 900, 1040, 1160, 1300, 1500}
    Public Shared peUni_fullSet() As Integer = {800, 900, 1040, 1160, 1300, 1500}

    Public Shared regUni_qty As Integer = 0
    Public Shared peUni_qty As Integer = 0

    Public Shared regUni_size As Integer = 0
    Public Shared peUni_size As Integer = 0

    Public Shared regUni_total As Integer = 0   ' Regular Uniform
    Public Shared peUni_total As Integer = 0    ' PE Uniform

    ' ===============================
    ' DISCOUNTS
    ' ===============================
    Public Shared discount_pwd As Double = 0.1      ' PWD Discount
    Public Shared discount_family As Double = 0.03  ' Family Discount (2+ enrolled)

    Public Shared discount_type As String = "None"
    Public Shared discount_percent As Double = 0

    ' ===============================
    ' PAYMENT TOTALS
    ' ===============================
    Public Shared tuition_total As Integer = 0
    Public Shared misc_total As Integer = 0
    Public Shared book_total As Integer = 0

    Public Shared intial_pay As Double = 0
    Public Shared total_pay As Double = 0

    ' ===============================
    ' SCHOOL MERCHANDISES
    ' ===============================
    Public Shared itemList() As (Name As String, Price As Integer) = {
        ("Cap", 300),
        ("Tumbler", 900),
        ("T-Shirt", 500),
        ("Sweatshirt", 890),
        ("Lanyard", 200),
        ("Tote Bag", 300),
        ("Mug", 300),
        ("Ballpen", 40),
        ("Pencil", 25),
        ("Notebook", 80),
        ("Crayons", 120),
        ("Colored pencils", 150),
        ("Ruler", 30),
        ("Scissors", 100),
        ("Cartolina", 25),
        ("Folder", 30),
        ("Sharpener", 25),
        ("Marker (permanent)", 50),
        ("Marker (whiteboard)", 50),
        ("Drawing book (A4)", 100),
        ("Glue Stick", 10),
        ("Regular Uniform (XS)", 800),
        ("Regular Uniform (S)", 900),
        ("Regular Uniform (M)", 1040),
        ("Regular Uniform (L)", 1160),
        ("Regular Uniform (XL)", 1300),
        ("Regular Uniform (2XL)", 1500),
        ("PE Uniform (XS)", 800),
        ("PE Uniform (S)", 900),
        ("PE Uniform (M)", 1040),
        ("PE Uniform (L)", 1160),
        ("PE Uniform (XL)", 1300),
        ("PE Uniform (2XL)", 1500)
    }

    Public Shared cartItem As New List(Of String)
    Public Shared cartPrice As New List(Of Integer)
    Public Shared cartTPrice As New List(Of Integer)
    Public Shared cartQty As New List(Of Integer)

    Public Shared supplyItem As New List(Of String)
    Public Shared supplyPrice As New List(Of Integer)
    Public Shared supplyTPrice As New List(Of Integer)
    Public Shared supplyQty As New List(Of Integer)

    Public Shared cartTotalPrice As Integer
    Public Shared cartPaid As Integer
    Public Shared cartChange As Integer

End Class
