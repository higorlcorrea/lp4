<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebVehicles.index" %>

<!DOCTYPE HTML>
<html>
<head>
    <title>WebVehicles</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <link href="/css/bootstrap.min.css" rel="stylesheet">
    <link href="/css/bootstrap-material-design.min.css" rel="stylesheet">

    <link href='http://fonts.googleapis.com/css?family=Lato:100,300,400,700,900' rel='stylesheet' type='text/css'>
    <link href="/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href="/css/owl.carousel.css" rel="stylesheet">
    <link href="/css/font-awesome.min.css" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="/css/magnific-popup.css">



    <script type="text/javascript" src="/js/jquery.min.js"></script>
    <script src="/js/owl.carousel.js"></script>
    <!-- //Owl Carousel Assets -->
    <!-----768px-menu----->
    <script type="text/javascript" src="/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="/js/material.min.js"></script>
    <script type="text/javascript" src="/js/ripples.min.js"></script>
    <script type="text/javascript" src="/js/jquery.mmenu.js"></script>
    <link type="text/css" rel="stylesheet" href="/css/jquery.mmenu.all.css" />
    <script type="text/javascript" src="/js/jquery.mmenu.js"></script>
    <script type="text/javascript">
        //	The menu on the left
        $(function () {
            $('nav#menu-left').mmenu();
        });
    </script>
    <!-----//768px-menu----->
</head>
<body>
    <!-- start header -->
    <div class="header_bg">
        <div class="wrap">
            <div class="header">
                <div class="logo">
                    <a href="index.html">
                        <img src="/images/lg.png" alt="" />
                        <h1>WebVehicles</h1>
                        <div class="clear"></div>
                    </a>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <!-- start header -->
    <div class="header_btm">
        <div class="wrap">
            <!------start-768px-menu---->
            <div id="page">
                <div id="header">
                    <a class="navicon" href="#menu-left"></a>
                </div>
                <nav id="menu-left">
                    <ul>
                        <li class="active"><a href="index.html">Inicio</a></li>
                        <li><a href="about.html">Sobre Nós</a></li>
                        <li><a href="services.html">Carros</a></li>
                        <li><a href="pages.html">Cadastrar Carro</a></li>
                    </ul>
                </nav>
            </div>
            <!------start-768px-menu---->
            <div class="header_sub">
                <div class="h_menu">
                    <ul>
                        <li class="active"><a href="index.html">Inicio</a></li>
                        <li><a href="about.html">Sobre Nós</a></li>
                        <li><a href="services.html">Carros</a></li>
                        <li><a href="pages.html">Cadastrar Carro</a></li>
                    </ul>
                </div>
                <div class="h_search">
                    <form>
                        <input type="text" value="" placeholder="Procurar carros...">
                        <input type="submit" value="">
                    </form>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <!---start-banner---->
    <div class="banner" id="move-top">
        <!----start-image-slider---->
        <div data-scroll-reveal="enter bottom but wait 0.7s" class="img-slider" id="home">
            <div class="wrap">
                <div class="slider">
                    <ul id="jquery-demo">
                        <li>
                            <a href="#slide1"></a>
                            <div data-scroll-reveal="enter bottom but wait 0.7s" class="slider-detils">
                                <h3>Precisa de um carro novo?</h3>
                                <span>Temos os melhores carros semi novos da região!</span>
                            </div>
                        </li>
                        <li>
                            <a href="#slide2"></a>
                            <div data-scroll-reveal="enter bottom but wait 1s" class="slider-detils">
                                <h3>Sem dinheiro?</h3>
                                <span>Faça uma simulação de financiamento conosco!</span>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="clear"></div>
    </div>
    <!---slider---->
    <link rel="stylesheet" href="/css/slippry.css">
    <script src="/js/jquery-ui.js" type="text/javascript"></script>
    <script src="/js/scripts-f0e4e0c2.js" type="text/javascript"></script>
    <script>
        jQuery('#jquery-demo').slippry({
            slippryWrapper: '<div class="sy-box jquery-demo" />',
            adaptiveHeight: false,
            useCSS: false,
            autoHover: false,
            transition: 'fade'
        });
    </script>

    <div class="last_posts">
        <!-- start last_posts -->
        <div class="wrap">
            <h5 class="heading">Carros em destaque</h5>
            <div class="l-grids">
                <div class="l-grid-1">
                    <div class="desc" style="color:white !important;">
                        <h3>Nome do carro</h3>
                        <div class="row">
                            <div class="col-md-3"><i class="fa fa-money fa-2x" style="position: relative; bottom: 4px"></i></div>
                            <div class="col-md-9">R$ 30.000,00</div>
                        </div>
                        <div class="row">
                            <div class="col-md-3"><i class="fa fa-money fa-2x" style="position: relative; bottom: 4px"></i></div>
                            <div class="col-md-9">R$ 30.000,00</div>
                        </div>
                        <div class="row">
                            <div class="col-md-3"><i class="fa fa-money fa-2x" style="position: relative; bottom: 4px"></i></div>
                            <div class="col-md-9">R$ 30.000,00</div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <a href="#" style="font: inherit; color: inherit;"><i class="fa fa-search fa-1x" style="position: relative; bottom: 1px"></i>Saiba mais</a><br />
                            </div>
                        </div>
                    </div>
                    <img src="/images/im.jpg">
                    <div class="clear"></div>
                </div>
                <div class="l-grid-1 l-grid-2">
                    <div class="desc">
                        <h3>Lorem ipsum dolor amet,consectetur</h3>
                        <span>2nd  &nbsp; sep</span>
                        <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium.</p>
                    </div>
                    <img src="/images/im.jpg">
                    <div class="clear"></div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <div class="testimonial">
        <!-- start last_posts -->
        <div class="wrap">
            <h5 class="heading">Testemunhos</h5>
            <div class="test-grids">
                <div class="test-desc">
                    <h3>Ótimo site!</h3>
                    <p>Um grande site que me ajudou a trocar meu carro. Estava a seis anos com um fusca e não conseguia vendê-lo!</p>
                    <p>Cadastrei meu antigo carro aqui no site e em cerca de dois dias consegui vendê-lo e o valor adquirido pude dar de entrada neste mesmo site, na opção de parcelamento.</p>
                    <p>Além de tudo neste site encontrei o menor valor para entrada em um financiamento em garagem!</p>
                </div>
                <div class="img_1">
                    <img src="/images/avator.png">
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>

    <div class="footer">
        <div class="wrap">
            <div class="footer-left" style="width: 100%; text-align: justify;">
                <h3>Quem somos</h3>
                <p>Criada em 1995, no início da internet brasileira, a WebMotors conquistou ao longo do tempo o posto de maior portal brasileiro no segmento automobilístico (Ibope Net View junho/2013).</p>

                <p>Em 2002, a WebMotors foi adquirida pelo ABN AMRO, e agora pertence ao Grupo Santander Brasil, um dos maiores bancos do mundo, e grande fomentador do mercado de automóveis no Brasil através de sua financeira, Santander Financiamentos.</p>

                <p>A WebMotors oferece aos seus usuários e clientes a oportunidade de usufruir da sua elevada e comprovada audiência, utilizando-se de produtos e serviços altamente eficientes.</p>

                <p>Na WebMotors são disponibilizados classificados para venda de veículos – com mais de 200 mil ofertas por mês –, programas de manutenção preventiva veicular e produtos específicos direcionados especialmente às Revendas de Veículos e empresas atuantes no segmento automobilístico, como fabricantes de veículos e autopeças, e outras empresas que atuam nesse segmento.</p>

                <p>A WebMotors também disponibiliza aos internautas vasto conteúdo editorial, como testes, comparativos, guia de compra, lançamentos e segredos; comportamento, bem-estar no trânsito e notícias de mercado. Conta também com colaboradores renomados e especializados no mundo do automóvel.</p>

                <p>Além disso, a WebMotors investe em tecnologia de ponta continuamente para manter a segurança dos dados e a sua privacidade durante toda a navegação. Usando as mais novas ferramentas, tecnologias e métodos disponíveis, a WebMotors garante disponibilidade e performance adequada para que sua experiência de navegação seja rápida e agradável.</p>

                <p>Faça um test-drive agora mesmo no maior e mais completo site de veículos da internet brasileira.</p>

            </div>
            <div class="clear"></div>
        </div>
    </div>
    <div class="copy">
        <p>© <%= DateTime.Now.Year %> Desenvolvido por <a href="https://www.linkedin.com/in/higor-manoel-lima-correa-080b3bb2" target="_blank">Higor Correa</a></p>
    </div>
</body>
</html>
