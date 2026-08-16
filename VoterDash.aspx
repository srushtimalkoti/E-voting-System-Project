<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VoterDash.aspx.cs" Inherits="Evoting2.VoterDash" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>E Voting System</title>
     <meta content="width=device-width, initial-scale=1.0" name="viewport">
    <meta content="Free HTML Templates" name="keywords">
    <meta content="Free HTML Templates" name="description">

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
        <a href="VoterDash.aspx" class="navbar-brand p-0">
            <h1 class="m-0 text-primary"><i class="fa fa-user-check"></i> E Voting System</h1>
        </a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarCollapse">
            <div class="navbar-nav ms-auto py-0">
                <a href="VoterDash.aspx" class="nav-item nav-link active">My Dashboard</a>
            </div>
            <a href="Home.aspx" class="btn btn-danger py-2 px-4 ms-3">Logout</a>
        </div>
    </nav>

    <h1 class='text-center mt-5 text-primary'>Voter Dashboard</h1>
        <div class="container-fluid py-5">
        <div class="container">
            <div class="row g-5">
                <div class="col-xl-12 col-lg-12 wow slideInUp" data-wow-delay="0.3s">
    <form id="form1" runat="server">
    <div class="row">
        <div class="col-md-4">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/GiveVote.aspx">
                <div class="card-body text-center" style="box-shadow: 0 0 40px black; min-height: 300px; max-height: 300px;">
                    <img style="width:300px;" src="https://media.istockphoto.com/id/1299656495/vector/vote-now-isolated-green-flat-banner-on-white-background-vector-illustration.jpg?s=612x612&w=0&k=20&c=g4qZjgPHfjUp-6HXRKhLhbYAtz20_0CA3WggZOIemeM=" />
                
                <h1>Vote Now</h1>
                </div>
            </asp:HyperLink>
        </div>
        <div class="col-md-4">
<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/MyVote.aspx">
<div class="card-body text-center" style="box-shadow: 0 0 40px black; min-height: 300px; max-height: 300px;">
                    <img style="width:300px;" src="https://governancenow.com/temp/voter41.jpg" />
                    
                <h1>My Vote</h1>
                </div>
</asp:HyperLink>
</div>
        <div class="col-md-4">

<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ShowResults.aspx">
    <div class="card-body text-center" style="box-shadow: 0 0 40px black; min-height: 300px; max-height: 300px;">
                    <img style="width:300px;" src="https://cdn.pixabay.com/photo/2018/03/18/10/49/result-3236285_640.jpg" />
                
                <h1>See Results</h1>
                </div>
</asp:HyperLink>
    </div>
    </div>
    </form>

    
    
      </div>
    </div>
    </div>
    </div>

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
