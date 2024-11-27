<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TMS_PROJECT.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section id="hero" class="d-flex justify-cntent-center align-items-center">
        <div id="heroCarousel" class="container carousel carousel-fade" data-ride="carousel">

            <!-- Slide 1 -->
            <div class="carousel-item active">
                <div class="carousel-container">
                    <h2 class="animate__animated animate__fadeInDown">Welcome to <span>SKILLSYNC</span></h2>
                    <p class="animate__animated animate__fadeInUp"></p>

                </div>
            </div>

            <!-- Slide 2 -->
            <div class="carousel-item">
                <div class="carousel-container">
                    <h2 class="animate__animated animate__fadeInDown"></h2>
                    <p class="animate__animated animate__fadeInUp"></p>

                </div>
            </div>

            <!-- Slide 3 -->
            <div class="carousel-item">
                <div class="carousel-container">
                    <h2 class="animate__animated animate__fadeInDown"></h2>
                    <p class="animate__animated animate__fadeInUp"></p>
                    
                </div>
            </div>

            <a class="carousel-control-prev" href="#heroCarousel" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon bx bx-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>

            <a class="carousel-control-next" href="#heroCarousel" role="button" data-slide="next">
                <span class="carousel-control-next-icon bx bx-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>

        </div>
    </section>
    <!-- ======= Services Section ======= -->
    <section class="services">
        <div class="container">

            <div class="row">
                <div class="col-md-6 col-lg-3 d-flex align-items-stretch" data-aos="fade-up">
                    <div class="icon-box icon-box-pink">
                        <div class="icon"><i class="bx bxl-dribbble"></i></div>
                        <h4 class="title"><a href=""></a></h4>
                        <p class="description">
                            <h3>Delivering Excellence</h3>
                            Discover Our Suite of Tailored Services.</p>
                    </div>
                </div>

                <div class="col-md-6 col-lg-3 d-flex align-items-stretch" data-aos="fade-up" data-aos-delay="100">
                    <div class="icon-box icon-box-cyan">
                        <div class="icon"><i class="bx bx-file"></i></div>
                        <h4 class="title"><a href=""></a></h4>
                        <p class="description">
                            <h3>Demonstrating Impact</h3>
                            Explore Our Diverse Project Portfolio</p>
                    </div>
                </div>

                <div class="col-md-6 col-lg-3 d-flex align-items-stretch" data-aos="fade-up" data-aos-delay="200">
                    <div class="icon-box icon-box-green">
                        <div class="icon"><i class="bx bx-tachometer"></i></div>
                        <h4 class="title"><a href=""></a></h4>
                        <p class="description">
                            <h3>Count on Us</h3>
                            24/7 Support for Seamless Operations.</p>
                    </div>
                </div>

                <div class="col-md-6 col-lg-3 d-flex align-items-stretch" data-aos="fade-up" data-aos-delay="200">
                    <div class="icon-box icon-box-blue">
                        <div class="icon"><i class="bx bx-world"></i></div>
                        <h4 class="title"><a href=""></a></h4>
                        <p class="description">
                            <h3>Unlocking Potential</h3>
                            Connecting Students and Tutors Worldwide</p>
                    </div>
                </div>

            </div>

        </div>
    </section>
    <!-- End Services Section -->

    <!-- ======= Why Us Section ======= -->
    <section class="why-us section-bg" data-aos="fade-up" date-aos-delay="200">
        <div class="container">

            <div class="row">
                <div class="col-lg-6 video-box">
                    <img src="assets/img/why-us.jpg" class="img-fluid" alt="">
                    <a href="https://www.youtube.com/watch?v=jDDaplaOz7Q" class="venobox play-btn mb-4" data-vbtype="video" data-autoplay="true"></a>
                </div>

                <div class="col-lg-6 d-flex flex-column justify-content-center p-5">

                    <div class="icon-box">
                        <div class="icon"><i class="bx bx-fingerprint"></i></div>
                        <h3 class="title"><a href="#"></a></h3>
                        <center>
                            <h4>Seamless and Secure</h4>
                        </center>
                        <p class="description"><i>Your unique identity ensures secure access to your digital world.</i></p>
                    </div>

                    <div class="icon-box">
                        <div class="icon"><i class="bx bx-gift"></i></div>
                        <h4 class="title"><a href=""></a></h4>
                        <center>
                            <h4>Surprise Deals</h4>
                        </center>
                        <center>
                            <p class="description"><i>Unlock fantastic offers that brighten your day.</i></p>
                        </center>
                    </div>

                </div>
            </div>

        </div>
    </section>
    <!-- End Why Us Section -->

    <!-- ======= Features Section ======= -->
    <section class="features">
        <div class="container">

            <div class="section-title">
                <h2>Features</h2>
                <p></p>
            </div>

            <div class="row" data-aos="fade-up">
                <div class="col-md-5">
                    <img src="assets/img/features-1.svg" class="img-fluid" alt="">
                </div>
                <div class="col-md-7 pt-4">
                    <h3><b>Profile Management</b></h3>
                    <ul>
                        <li><i class="icofont-check"></i><i style="color: black;">Customizable profiles for tutors</i></li>
                        <li><i class="icofont-check"></i><i style="color: black;">Personalized student profiles</i></li>
                    </ul>
                </div>
            </div>

            <div class="row" data-aos="fade-up">
                <div class="col-md-5 order-1 order-md-2">
                    <img src="assets/img/features-2.svg" class="img-fluid" alt="">
                </div>
                <div class="col-md-7 pt-5 order-2 order-md-1">
                    <h3><b>Data-Driven Success</b></h3>
                    <p class="font-italic">
                        <b>Virtual Classrooms<br /></b> Integration of live video conferencing, shared whiteboards, 
                and instant messaging to create an interactive and engaging learning environment.                    
                    </p>
                    <p>
                    </p>
                </div>
            </div>

            <div class="row" data-aos="fade-up">
                <div class="col-md-5">
                    <img src="assets/img/features-3.svg" class="img-fluid" alt="">
                </div>
                <div class="col-md-7 pt-5">
                    <h3><b>Community Building</b></h3>
                    <p class="font-italic">
                        <b>User Forums and Discussions:</b> Create platforms for students and tutors to share experiences, ask questions, and build a supportive learning community.
                    </p>
                    <br />
                    <p>
                        <b><i>Resource Sharing</i></b> Sharing of resources, tips, and best practices among users to enhance the learning experience.
                    </p>
                    <ul>
                        <li><i class="icofont-check"></i><i style="color: black;">Discussion Forums</li>
                        <li><i class="icofont-check"></i><i style="color: black;">Collaborative Projects</li>
                        <li><i class="icofont-check"></i><i style="color: black;">Resource Links</li>
                    </ul>
                </div>
            </div>

            <div class="row" data-aos="fade-up">
                <div class="col-md-5 order-1 order-md-2">
                    <img src="assets/img/features-4.svg" class="img-fluid" alt="">
                </div>
                <div class="col-md-7 pt-5 order-2 order-md-1">
                    <h3><b>Tutor Performance Metrics</b></h3>
                    <p class="font-italic">
                        Analyze data on tutor effectiveness, including student feedback, session ratings, and improvement in student grades.
Student Progress Tracking: Monitor student performance over time to identify trends, strengths, and areas needing improvement.
                    </p>
                    <p>
                    </p>
                </div>
            </div>

        </div>
    </section>
    <!-- End Features Section -->


</asp:Content>
