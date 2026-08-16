<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Evoting2.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>E Voting System</title>
     <meta content="width=device-width, initial-scale=1.0" name="viewport">
    <meta content="Free HTML Templates" name="keywords">
    <meta content="Free HTML Templates" name="description



    <!-- Favicon -->
    <link href="CssTemplate/img/favicon.ico" rel="icon">

    <!-- Google Web Fonts -->
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Jost:wght@500;600;700&family=Open+Sans:wght@400;600&display=swap" rel="stylesheet"> 

    <!-- Icon Font Stylesheet -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css" rel="stylesheet">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css" rel="stylesheet">

    <!-- Libraries Stylesheet -->
    <link href="CssTemplate/lib/owlcarousel/assets/owl.carousel.min.css" rel="stylesheet">
    <link href="CssTemplate/lib/animate/animate.min.css" rel="stylesheet">
    <link href="CssTemplate/lib/tempusdominus/css/tempusdominus-bootstrap-4.min.css" rel="stylesheet" />
    <link href="CssTemplate/lib/twentytwenty/twentytwenty.css" rel="stylesheet" />

    <!-- Customized Bootstrap Stylesheet -->
    <link href="CssTemplate/css/bootstrap.min.css" rel="stylesheet">

    <!-- Template Stylesheet -->
    <link href="CssTemplate/css/style.css" rel="stylesheet">
</head>
<body>
 <!-- Spinner Start -->
    <div id="spinner" class="show bg-white position-fixed translate-middle w-100 vh-100 top-50 start-50 d-flex align-items-center justify-content-center">
        <div class="spinner-grow text-primary m-1" role="status">
            <span class="sr-only">Loading...</span>
        </div>
        <div class="spinner-grow text-dark m-1" role="status">
            <span class="sr-only">Loading...</span>
        </div>
        <div class="spinner-grow text-secondary m-1" role="status">
            <span class="sr-only">Loading...</span>
        </div>
    </div>
    <!-- Spinner End -->

    <nav class="navbar navbar-expand-lg bg-white navbar-light shadow-sm px-5 py-3 py-lg-0">
        <a href="Home.aspx" class="navbar-brand p-0">
            <h1 class="m-0 text-primary"><i class="fa fa-user-check"></i> E Voting System</h1>
        </a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarCollapse">
            <div class="navbar-nav ms-auto py-0">
                <a href="VoterLogin.aspx" class="nav-item nav-link active">Voter</a>
                <a href="AdminLogin.aspx" class="nav-item nav-link active">Admin</a>
            </div>
        </div>
    </nav>

        <div class="container-fluid p-0">
        <div id="header-carousel" class="carousel slide carousel-fade" data-bs-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img class="w-100" src="https://miro.medium.com/v2/resize:fit:1000/1*_f6wcIxwnEUlRyz7Ez3xRw.jpeg" alt="Image">
                    <div class="carousel-caption d-flex flex-column align-items-center justify-content-center">
                        <div class="p-3" style="max-width: 900px;">
                            <h1 class="display-1 text-white mb-md-4 animated zoomIn">Online Voting Platform</h1>
                            <a href="VoterLogin.aspx" class="btn btn-primary py-md-3 px-md-5 me-3 animated slideInLeft">Login To Continue</a>
                        </div>
                    </div>
                </div>
                <div class="carousel-item">
                    <img class="w-100" src="https://miro.medium.com/v2/resize:fit:1000/1*_f6wcIxwnEUlRyz7Ez3xRw.jpeg" alt="Image">
                    <div class="carousel-caption d-flex flex-column align-items-center justify-content-center">
                        <div class="p-3" style="max-width: 900px;">
                            <h1 class="display-1 text-white mb-md-4 animated zoomIn">Developed By Srushti & Janaki</h1>
                            <a href="VoterLogin.aspx" class="btn btn-primary py-md-3 px-md-5 me-3 animated slideInLeft">Login to Continue</a>
                        </div>
                    </div>
                </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#header-carousel"
                data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#header-carousel"
                data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>
    </div>
    <div class="container-fluid py-5 wow fadeInUp" data-wow-delay="0.1s">
        <div class="container">
            <div class="row g-5">
                <div class="col-lg-7">
                    <div class="section-title mb-4">
                        <h5 class="position-relative d-inline-block text-primary text-uppercase">About</h5>
                        <h1 class="display-5 mb-0">100% Secured Voting System</h1>
                    </div>
                    <h4 class="text-body fst-italic mb-4">Developed By Srushti & Janaki</h4>
                    <p class="text-primary mb-4">Following are the steps you can follow to vote</p>
                    <div class="row g-3">
                        <div class="col-sm-12 wow zoomIn" data-wow-delay="0.3s">
                            <h5 class="mb-3"><i class="fa fa-check-circle text-primary me-3"></i>Login</h5>
                            <h5 class="mb-3"><i class="fa fa-check-circle text-primary me-3"></i>Cast your Vote</h5>
                            <h5 class="mb-3"><i class="fa fa-check-circle text-primary me-3"></i>Check your Vote</h5>
                            <h5 class="mb-3"><i class="fa fa-check-circle text-primary me-3"></i>See Results</h5>
                        </div>
                    </div>
                    <a href="VoterLogin.aspx" class="btn btn-primary py-3 px-5 mt-4 wow zoomIn" data-wow-delay="0.6s">Vote Now</a>
                </div>
                <div class="col-lg-5" style="min-height: 500px;">
                    <div class="position-relative h-100">
                        <img class="position-absolute w-100 h-100 rounded wow zoomIn" data-wow-delay="0.9s" src="https://electionbuddy.com/wp-content/uploads/2022/01/Voting-image-6-scaled.jpg" style="object-fit: cover;">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
    


     <!-- Back to Top -->
    <a href="#" class="btn btn-lg btn-primary btn-lg-square rounded back-to-top"><i class="bi bi-arrow-up"></i></a>


    <!-- JavaScript Libraries -->
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"></script>
    <script src="CssTemplate/lib/wow/wow.min.js"></script>
    <script src="CssTemplate/lib/easing/easing.min.js"></script>
    <script src="CssTemplate/lib/waypoints/waypoints.min.js"></script>
    <script src="CssTemplate/lib/owlcarousel/owl.carousel.min.js"></script>
    <script src="CssTemplate/lib/tempusdominus/js/moment.min.js"></script>
    <script src="CssTemplate/lib/tempusdominus/js/moment-timezone.min.js"></script>
    <script src="CssTemplate/lib/tempusdominus/js/tempusdominus-bootstrap-4.min.js"></script>
    <script src="CssTemplate/lib/twentytwenty/jquery.event.move.js"></script>
    <script src="CssTemplate/lib/twentytwenty/jquery.twentytwenty.js"></script>

    <!-- Template Javascript -->
    <script src="CssTemplate/js/main.js"></script>
</body>
</html>
