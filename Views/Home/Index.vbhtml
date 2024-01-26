﻿@Code
    ViewData("Title") = "Home Page"
End Code


<!DOCTYPE html>
<html lang="tr">

<!-- Mirrored from reva.bouthythemes.com/index-particles.html by HTTrack Website Copier/3.x [XR&CO'2014], Sat, 05 Aug 2023 11:17:06 GMT -->
<head>

    <!-- meta Data -->
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <!-- title -->
    <title>My One Page</title>

    <!-- stylesheet -->
    <link rel="stylesheet" href="/assets/css/fontawesome-all.min.css" />
    <link rel="stylesheet" href="/assets/css/bootstrap.min.css" />
    <link rel="stylesheet" href="/assets/css/main.css" />
    <link rel="stylesheet" href="/assets/css/responsive.css" />
    <link rel="stylesheet" href="/assets/css/light_template.html" />
    <link rel="stylesheet" href="/assets/css/colors/default-color.css" />

    <!-- Plugins -->
    <link rel="stylesheet" href="/assets/css/magnific-popup.css" />

    <!-- google Fonts -->
    <link rel="stylesheet" href="https://fonts.gstatic.com/s/kaushanscript/v14/vm8vdRfvXFLG3OLnsO15WYS5DG74wNI.woff2|Poppins:300i,400,600" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>

    <!-- Start Section Tool Box -->

    <div class="option-box">
        <div class="color-option">
            <ul class="list-unstyled colors">
                <li data-value="/assets/css/colors/default-color.css"></li>
                <li data-value="/assets/css/colors/green-color.css"></li>
                <li data-value="/assets/css/colors/pink-color.css"></li>
                <li data-value="/assets/css/colors/blue-color.css"></li>
                <li data-value="/assets/css/colors/purple-color.css"></li>
            </ul>
        </div>
        <div class="gear-check">
            <i class="fas fa-cog fa-spin"></i>
        </div>
    </div>

    <!-- End Section Tool Box -->
    <!-- Start Navbar -->
    <nav class="navbar fixed-top navbar-expand-lg navbar-light">

        <div class="container">
            <a href="#" class="logo">
                <span class="bg_logo"></span>
                <!-- You Can Edit the image on main.css file just search ( bg_logo ) -->
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <div class="menu">
                    <span class="line1"></span>
                    <span class="line2"></span>
                    <span class="line3"></span>
                </div>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav ml-auto">
                    <li id="home" class="nav-item active-nav">
                        <a href="#home-cont" data-value="home-cont">
                            <i class="icon-home" hidden></i>
                            <span class="name-menu">Giriş</span>
                        </a>
                    </li>
                    <li id="about" class="nav-item">
                        <a href="#about-cont" data-value="about-cont">
                            <i class="icon-male-user" hidden></i>
                            <span class="name-menu">Hakkımda</span>
                        </a>
                    </li>
                    <li id="serv" class="nav-item">
                        <a href="#serv-cont" data-value="serv-cont">
                            <i class="icon-layers" hidden></i>
                            <span class="name-menu">Hizmetler</span>
                        </a>
                    </li>
                    <li id="work" class="nav-item">
                        <a href="#work-cont" data-value="work-cont">
                            <i class="icon-picture" hidden></i>
                            <span class="name-menu">Portföy</span>
                        </a>
                    <li id="contact" class="nav-item">
                        <a href="#contact-cont" data-value="contact-cont">
                            <i class="icon-envelope" hidden></i>
                            <span class="name-menu">İletişim</span>
                        </a>
                    </li>
                </ul>
            </div>
            <div class="social-media">
                <a href="https://github.com/MeryJan1" target="_blank"><i class="fab fa-github"></i></a> <!-- You Can Edit the link here -->
                <a href="https://www.linkedin.com/in/meryem-a%C5%9Fkaro%C4%9Flu/" target="_blank"><i class="fab fa-linkedin"></i></a> <!-- You Can Edit the link here -->
                <a href="https://www.youtube.com/" target="_blank"><i class="fab fa-youtube"></i></a> <!-- You Can Edit the link here -->
                <a href="https://www.instagram.com/meryemaskaroglu91/" target="_blank"><i class="fab fa-instagram"></i></a> <!-- You Can Edit the link here -->
            </div>
            <div class="collapse-menu">
                <span class="collapse-icon closed-menu"></span>
            </div>
        </div>
    </nav>
    <div class="nav-toggle">
        <div class="menu">
            <span class="line1"></span>
            <span class="line2"></span>
            <span class="line3"></span>
        </div>
    </div>
    <!-- End Navbar -->
    <!-- Start Header -->

    <section id="home-cont" class="home1 home">
        <div id="particles-js" class="particles">
            <div class="title">
                <h1 class="text-uppercase"><strong>Meryem</strong> Aşkaroğlu</h1>
                <p class="type"></p>  <!-- You Can Edit the title on the custom.jscustom.js File -->
                <div class="btn-home">
                    <a href="#work-cont">Portföy</a>
                </div>
            </div>
        </div>
    </section>

    <!-- End Header -->
    <!-- Start About -->
    <section id="about-cont" class="about">
        <div class="title">
            <h1 class="kaushan">HAKKIMIZDA</h1>
        </div>
        <div class="container">

            <div class="row">
                <div class="col-md-10 col-lg-6">
                    <div class="about-img bg-image"></div>
                    <!-- go to main.scss file to edit personal image -->
                </div>
                <div class="col-md-12 col-lg-6">
                    <div class="tabs-about">
                        <ul class="nav nav-tabs text-center" id="myTab" role="tablist">

                            <!-- Start About Me Title Tab -->
                            <li class="nav-item">
                                <a class="nav-link active" id="about-tab" data-toggle="tab" href="#aboutme" role="tab" aria-controls="about" aria-expanded="true">
                                    <i class="icon-male-user"></i>
                                    <span>Hakkımda</span>
                                </a>
                            </li>
                            <!-- End About Me Title Tab -->
                            <!-- ================ -->
                            <!-- Start Profile Title Tab -->
                            <li class="nav-item">
                                <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile">
                                    <i class="icon-star"></i>
                                    <span>Profil</span>
                                </a>
                            </li>
                            <!-- End Profile Title Tab -->
                            <!-- ================ -->
                            <!-- Start Skills Title Tab -->
                            <li class="nav-item">
                                <a class="nav-link" id="skill-tab" data-toggle="tab" href="#skill" role="tab" aria-controls="skill">
                                    <i class="icon-magic-wand"></i>
                                    <span>Yetenekler</span>
                                </a>
                            </li>
                            <!-- End Skills Title Tab -->
                        </ul>
                        <div class="tab-content" id="myTabContent">

                            <!-- Start About Me Tab -->
                            <div class="tab-pane fade show active text-left" id="aboutme" role="tabpanel" aria-labelledby="about-tab">
                                <p>Adım Meryem AŞKAROĞLU 19 yaşındayım ve Mersin'de yaşıyorum. İskenderun Teknik Üniversitesi Bilgisayar Mühendiliği öğrencisiyim. </p>
                                <p>Bir süredir Siber Güvenlik Uzmanlığı eğitimi alıyorum. Bu alanda birçok yeni şey öğrendim ve öğrenmeye de devam ediyorum. Örneğin; Network Temellerini, Pentesterlığı, SOC Temellerini ve Splunk kullanmayı öğrendim. Aynı zamanda web siteleri oluşturmayı ve bu alanda da kendimi geliştirmeyi istiyorum.</p>
                                <p>Boş zamanlarımda resim yapmaktan, müzikten ve bitkilerle ilgilenmekten çok hoşlanırım. Resim alanında yarışma derecelerim bulunmaktadır. Gitar çalmayı da severim. Beni rahatlatır ve mutlu eder. Bitkileri araştırmaktan ve onlara bakım yapmaktan da çok hoşlanırım. Yararlarını bilmediğim daha birçok bitki var ve onları da öğrenmek istiyorum. </p>
                                <img src="/assets/images/signature.png" class="img-fluid signature" alt="signature" />
                                <!-- Here image Signature -->
                            </div>
                            <!-- End About Me Tab -->
                            <!-- ================ -->
                            <!-- Start Profile Tab -->
                            <div class="tab-pane fade text-left profile" id="profile" role="tabpanel" aria-labelledby="profile-tab">
                                <h6><span class="title-info">Name :</span><span>Meryem Aşkaroğlu</span></h6> <!-- Edit Your Name  -->
                                <h6><span class="title-info">Nationality : </span><span>Türkiye</span></h6> <!-- Edit Your Nationality  -->
                                <h6><span class="title-info">Email : </span><span>meryemaskaroglu6@gmail.com</span></h6> <!-- Edit Your Email  -->
                                <h6><span class="title-info">Date of birth : </span><span>17.06.2004</span></h6> <!-- Edit Your Date Of Birth  -->
                                <h6><span class="title-info">Phone : </span><span>+905050540508</span></h6> <!-- Edit Your Phone -->

                                <div class="btn-about">
                                    <a href="#">Özgeçmişi İndir</a>
                                </div>
                            </div>
                            <!-- End Profile Tab -->
                            <!-- ================ -->
                            <!-- Start Skills Tab -->
                            <div class="tab-pane fade skill" id="skill" role="tabpanel" aria-labelledby="skill-tab">
                                <div class="skills">
                                    <p class="progress-text">NETWORK FUNDAMENTALS</p> <!-- Here You Can Edit The Name Of Skill -->
                                    <div class="progress">
                                        <div class="progress-bar" data-present="70%"></div> <!-- Here You Can Edit The Percentage -->
                                    </div>
                                    <p class="progress-text">PENETRATION TESTER</p> <!-- Here You Can Edit The Name Of Skill -->
                                    <div class="progress">
                                        <div class="progress-bar" data-present="89%"></div> <!-- Here You Can Edit The Percentage -->
                                    </div>
                                    <p class="progress-text">SOC LEVEL 1 ANALYST</p> <!-- Here You Can Edit The Name Of Skill -->
                                    <div class="progress">
                                        <div class="progress-bar" data-present="65%"></div> <!-- Here You Can Edit The Percentage -->
                                    </div>
                                    <p class="progress-text">SOC LEVEL-2 INCIDENT RESPONDER</p> <!-- Here You Can Edit The Name Of Skill -->
                                    <div class="progress">
                                        <div class="progress-bar" data-present="68%"></div> <!-- Here You Can Edit The Percentage -->
                                    </div>
                                </div>
                                <div class="btn-about">
                                    <a href="#contact-cont">İşe Al</a>
                                </div>
                            </div>
                            <!-- End Skills Tab -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- End About -->
    <!-- Start Services -->
    <section id="serv-cont" class="serv">
        <div class="title">
            <h1 class="kaushan">HİZMETLER</h1>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-lg-6">
                    <div class="servs">
                        <div class="row">
                            <div class="col-lg-6">
                                <div class="content">
                                    <img src="https://miro.medium.com/v2/resize:fit:512/0*xfNNkZ6oXno1Dgum.png" alt="serv1" />
                                    <h4>NETWORK FUNDAMENTALS</h4>
                                    <ul style="list-style-type:square">
                                        <li>Temel olarak Network oluşturma, yapılandırma ve güvenliğini sağlama.</li>

                                    </ul>
                                </div>
                            </div>
                            <div class="col-lg-6">
                                <div class="content">
                                    <img src="data:image/png;base64,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" alt="serv1" />
                                    <h4>PENTESTER</h4>
                                    <ul style="list-style-type:square">
                                        <li>Temel Web hacking, Vulnerability Search, Network Security.</li>
                                        <li>Burp Suite ve Metasploit kullanma. </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-6">
                                <div class="content">
                                    <img src="data:image/jpeg;base64,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" alt="serv1" />
                                    <h4>SOC L1</h4>
                                    <ul style="list-style-type:square">
                                        <li>
                                            Cyber Threat Intelligence, Network Security and Traffic Analysis

                                        </li>
                                        <li>
                                            Endpoint Security Monitoring, Security Information Event Management

                                        </li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-lg-6">
                                <div class="content">
                                    <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTR8uEWSed_tXa6_iP0hoFexc2qykSpd5sJCA&usqp=CAU" alt="serv1" />
                                    <h4>SOC L2</h4>
                                    <ul style="list-style-type:square">
                                        <li>Fortigate Firewall, IBM QRadar kullanma.</li>
                                        <li>Log Investigation With Splunk</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6 col-md-12">
                    <div class="serv-vid bg-image">
                        <a class="play video" href="https://www.youtube.com/watch?v=96kI8Mp1uOU">
                            <!-- you can edit the link here -->
                            <i class="fas fa-play"></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- End Services -->
    <!-- Start Work -->
    <section id="work-cont" class="work">
        <div class="title">
            <h1 class="kaushan">PORTFÖY</h1>
        </div>
        <div class="container">
            <div class="shuffle">
                <ul class="list-unstyled">
                    <li data-class="all" class="active item">Tümü</li>
                    <li data-class=".web" class="item">Network Fundamentals<!--<div class="item web">--></li>
                    <li data-class=".graphic" class="item">SOCL2</li><!--class=Graphic-->
                    <!--  <li data-class=".marketing" class="item"></li> <div class="item marketing">  -->
                </ul>
            </div>
            <div class="gallery">
                <div class="row">
                    <!-- Start Image Number 1 -->
                    <div class="col-lg-4 col-md-6 col-sm-12">
                        <div class="item web">
                            <div class="over">
                                <div class="info-img">
                                    <h4>Cisco Packet Tracer</h4>
                                    <span>Network</span>
                                </div>
                                <a class="image" href="/assets/images/portfolio/01.jpg">
                                    <!-- ^ And Here -->
                                    <i class="fa fa-arrows-alt"></i>
                                </a>
                            </div>
                            <img src="/assets/images/portfolio/01.jpg" alt="imgPort1" class="img-fluid">
                            <!-- Here ^ You Can Change image And Up -->
                        </div>
                    </div>
                    <!-- End Image Number 1 -->
                    <!-- ===================== -->
                    <!-- Start Image Number 2 -->
                    <div class="col-lg-4 col-md-6 col-sm-12">
                        <div class="item graphic">
                            <div class="over">
                                <div class="info-img">
                                    <h4>SPLUNK ENTERPRİSE</h4>
                                    <span>SOC L2</span>
                                </div>
                                <a class="image" href="/assets/images/portfolio/02.jpg">
                                    <!-- ^ And Here -->
                                    <i class="fa fa-arrows-alt"></i>
                                </a>
                            </div>
                            <img src="/assets/images/portfolio/02.jpg" alt="imgPort1" class="img-fluid">
                            <!-- Here ^ You Can Change image And Up -->
                        </div>
                    </div>
                    <!-- End Image Number 2 -->
                    <!-- ===================== -->
                    <!-- Start Image Number 3 WEB DESİNG DI -->
                    <!-- End Image Number 3 -->
                    <!-- ===================== -->
                    <!-- Start Image Number 4- Networktü -->
                    <!-- End Image Number 4 -->
                    <!-- ===================== -->
                    <!-- Start Image Number 5 WEB DESİNG DI -->
                    <!-- End Image Number 5 -->
                    <!-- ===================== -->
                    <!-- Start Image Number 6 -->
                    <div class="col-lg-4 col-md-6 col-sm-12">
                        <div class="item graphic">
                            <div class="over">
                                <div class="info-img">
                                    <h4>Eve-Topology</h4>
                                    <span>SOC L2</span>
                                </div>
                                <a class="image" href="/assets/images/portfolio/06.jpg">
                                    <!-- ^ And Here -->
                                    <i class="fa fa-arrows-alt"></i>
                                </a>
                            </div>
                            <img src="/assets/images/portfolio/06.jpg" alt="imgPort1" class="img-fluid">
                            <!-- Here ^ You Can Change image And Up -->
                        </div>
                    </div>
                    <!-- End Image Number 6 -->
                    <!-- ===================== -->
                    <!-- Start Image Number 7 marketing -->
                    <!-- End Image Number 7 -->
                    <!-- ===================== -->
                    <!-- Start Image Number 8 -->
                    <div class="col-lg-4 col-md-6 col-sm-12">
                        <div class="item graphic less">
                            <div class="over">
                                <div class="info-img">
                                    <h4>FortiNet FortiGate</h4>
                                    <span>SOC L2</span>
                                </div>
                                <a class="image" href="/assets/images/portfolio/08.jpg">
                                    <!-- ^ And Here -->
                                    <i class="fa fa-arrows-alt"></i>
                                </a>
                            </div>
                            <img src="/assets/images/portfolio/08.jpg" alt="imgPort1" class="img-fluid">
                            <!-- Here ^ You Can Change image And Up -->
                        </div>
                    </div>
                    <!-- End Image Number 8 -->
                    <!-- ===================== -->
                    <!-- Start Image Number 9 <div class="item web less">-->
                    <!-- End Image Number 9 -->
                    <!-- You can add more images here.. -->
                </div>
            </div>
        </div>
    </section>

    <!-- End Work -->
    <!--  <!-- Start Testimonials -->
    <!-- Start Contact -->
    <section id="contact-cont" class="contact">
        <div class="title">
            <h1 class="kaushan">İLETİŞİM</h1>
        </div>
        <div class="row">
            <div class="col-md-6 col-sm-12">
                <div class="form">
                    <form id="my_form" method="post" onsubmit="submitForm(); return false;">
                        <div class="row">
                            <div class="col-6">
                                <div class="form-group">
                                    <input id="name" class="form-control" type="text" name="name" placeholder="İsmin" required />
                                </div>
                            </div>
                            <div class="col-6">
                                <div class="form-group">
                                    <input id="email" class="form-control" type="email" name="email" placeholder="Mail Adresi" required />
                                </div>
                            </div>
                            <div class="col-6">
                                <div class="form-group">
                                    <input id="phone" class="form-control" type="tel" name="phone" placeholder="Telefon Numarası" />
                                </div>
                            </div>
                            <div class="col-6">
                                <div class="form-group">
                                    <input id="subject" class="form-control" type="text" name="subject" placeholder="Konu" />
                                </div>
                            </div>
                        </div>
                        <div class="message">
                            <div class="form-group">
                                <textarea id="msg" class="form-control" placeholder="Mesajımızı buraya yazınız ..." required></textarea>
                            </div>
                            <p>
                                <span class="send-btn">
                                    <input id="btn" class="btn" type="submit" value="Mesaj Gönder" /><i class="fas fa-long-arrow-alt-right"></i>
                                </span>
                                <span id="status"></span>
                            </p>
                        </div>
                    </form>
                </div>
            </div>
            <div class="col-md-6 col-sm-12">
                <div class="infos background-gradient">
                    <h2 class="text-uppercase kaushan"></h2>
                    <div class="email">
                        <i class="fas fa-envelope"></i>
                        <a href="mailto:meryemaskaroglu91@gmail.com">meryemaskaroglu91@gmail.com</a>
                    </div>
                    <div class="phone">
                        <i class="fas fa-phone"></i>
                        <a href="tel:+905050540508">05050540508</a>
                    </div>
                    <div class="address">
                        <i class="fas fa-map-marker-alt"></i>
                        <span>123 Street Name, City , 32008</span>
                    </div>
                </div>
            </div>
        </div>
        <div class="maps" id="overlay">
            <div class="open-map">
                <span class="o-map active"><i class="fas fa-arrow-alt-circle-down"></i>Open Map</span>
                <span class="c-map"><i class="fas fa-arrow-alt-circle-up"></i>Close Map</span>
            </div>
            <div class="google-wrapper">
                <div id="google-map">
                    <!-- You Can Add Your Location Here Just Go To Google Map And Emped Map and past it down v -->
                    <iframe id="map" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d162778.81964475298!2d-73.93891815355539!3d40.703660465248056!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c24fa5d33f083b%3A0xc80b8f06e177fe62!2sNew+York%2C+NY!5e0!3m2!1sen!2s!4v1491335061565"></iframe>
                </div>
            </div>
        </div>

        <!-- Start Footer -->
        <!-- End Footer -->
    </section>

    <!-- End Contact -->
    <!-- Start Loading -->

    <div class="loading">
        <div class="blob-grid">
            <div class="blob blob-0"></div>
            <div class="blob blob-1"></div>
            <div class="blob blob-2"></div>
            <div class="blob blob-3"></div>
            <div class="blob blob-4"></div>
            <div class="blob blob-5"></div>
        </div>
    </div>

    <!-- End Loading -->


    <script src="/assets/js/jquery-3.1.1.min.js"></script>
    <script src="/assets/js/jquery.magnific-popup.min.js"></script>
    <script src="/assets/js/typed.js"></script>
    <script src="/assets/js/popper.min.js"></script>
    <script src="/assets/js/bootstrap.min.js"></script>
    <script src="/assets/js/particles.min.js"></script>
    <script src="/assets/js/app.js"></script>
    <script src="/assets/js/custom.js"></script>
</body>

<!-- Mirrored from reva.bouthythemes.com/index-particles.html by HTTrack Website Copier/3.x [XR&CO'2014], Sat, 05 Aug 2023 11:17:23 GMT -->
</html>
