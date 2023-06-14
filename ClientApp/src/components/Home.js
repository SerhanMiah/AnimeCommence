import React from 'react'
import { Container, Row, Col, Button } from 'react-bootstrap';
import '../Style/HomePage.css';
// import animeVideo from '../assets/animeVideo.mp4'

export default function Home() {
  return (
    <Container fluid className="homeContainer">
      <video autoPlay loop muted className="backgroundVideo">
        {/* <source src={animeVideo} type="video/mp4"/> */}
      </video>
      <div className="videoOverlay" />
      <Row className="homeRow text-center">
        <Col>
          <h1>Welcome to Anime Shop</h1>
          <p>
            Your one-stop destination for all your favorite anime merch!
          </p>
          <Button variant="outline-light" className="learnMoreButton">Shop Now</Button>
        </Col>
      </Row>

      {/* <Row className="categoryRow text-center">
        <Col>
          <h2>Our Categories</h2>
          <Row className="categoryItems">
            <Col><a href="/manga">Manga</a></Col>
            <Col><a href="/anime">Anime</a></Col>
            <Col><a href="/merch">Merch</a></Col>
            <Col><a href="/new-releases">New Releases</a></Col>
          </Row>
        </Col>
      </Row> */}
      
      {/* <Row className="newsletterRow text-center">
        <Col>
          <h2>Subscribe to our Newsletter</h2>
          <form>
            <input type="email" placeholder="Email address"/>
            <Button variant="outline-light" className="subscribeButton">Subscribe</Button>
          </form>
        </Col>
      </Row> */}
    </Container>
  );
}
