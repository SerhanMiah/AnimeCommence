import React from 'react';
import { Container, Row, Col, Button } from 'react-bootstrap';
import { Link } from 'react-router-dom';
import '../Style/HomePage.css';
import animeBackground from '../assests/animeBackground.jpg';

export default function Home() {
  return (
    <div className="homeContainer">
      <div className="backgroundImage" style={{ backgroundImage: `url(${animeBackground})` }} />
      <div className="videoOverlay" />
      <Container className="homeContent">
        <Row className="homeRow text-center">
          <Col>
            <h1 className="homeTitle">Welcome to Anime Shop</h1>
            <p className="homeSubtitle">
              Your one-stop destination for all your favorite anime merch!
            </p>
            <Button variant="outline-light" className="homeButton">
              <Link to="/register" className="homeLink">Register</Link>
            </Button>
            <Button variant="outline-light" className="homeButton">
              <Link to="/login" className="homeLink">Login</Link>
            </Button>
          </Col>
        </Row>
        <div className="scrollDown">
          <p>Scroll down to explore</p>
          <div className="arrowIcon" />
        </div>
      </Container>
    </div>
  );
}
