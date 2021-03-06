<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark" style="background-color: #5f186e;">
        <a class="navbar-brand" <img src="/docs/4.0/assets/brand/bootstrap-solid.svg" width="30" height="30" alt=""></a>
        <a class="navbar-brand" href="/Home">The Eisenhower Project</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
            <div class="navbar-nav">
                <a class="nav-item nav-link active prestonbutton" href="/Home">Home</a>
                <a class="nav-item nav-link prestonbutton" href="/Diagram">Diagram</a>
                <button class="btn btn-outline-success prestonbutton" type="button">Main button</button>
                <button class="btn btn-outline-success prestonbutton" type="button">Main button</button>
            </div>
        </div>
    </nav>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
