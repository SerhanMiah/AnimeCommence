import React from 'react'
import { Container, Row, Col, Button } from 'react-bootstrap';
import '../Style/HomePage.css';
import animeBackground from '../assests/animeBackground.jpg' 

export default function Home() {
  return (
    <Container fluid className="homeContainer">
      <Row className="homeRow text-center">
        <Col>
          <h1>Welcome to Anime Shop</h1>
          <p>
            Your one-stop destination for all your favorite anime merch!
          </p>
          <Button variant="outline-light" className="learnMoreButton">Learn more</Button>
        </Col>
      </Row>
    </Container>
  )
}
