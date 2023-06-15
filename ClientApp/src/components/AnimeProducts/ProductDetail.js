import React, { useEffect, useState } from 'react';
import { useParams, Link } from 'react-router-dom';
import axios from 'axios';
import { Carousel } from 'react-responsive-carousel';
import 'react-responsive-carousel/lib/styles/carousel.min.css';
import { Typography, Button, IconButton, TextField, Grid, Box, Rating } from '@mui/material';
import { Add, Remove } from '@mui/icons-material';
import '../../Style/ProductDetail.css';

export default function ProductDetail() {
  const [product, setProduct] = useState({});
  const [quantity, setQuantity] = useState(1);
  const [images, setImages] = useState([]);
  const [reviews, setReviews] = useState([]);
  const [reviewText, setReviewText] = useState('');

  const { id } = useParams();
  useEffect(() => {
    const getData = async () => {
      try {
        const { data } = await axios.get(`http://localhost:5000/api/product/${id}`);
        setProduct(data);
        setImages(data.images && data.images.$values ? data.images.$values.map(image => image.imageUrl) : []);
        setReviews([{ author: 'User1', text: 'Great product!' }, { author: 'User2', text: 'Awesome!' }]); // Fetch actual reviews here
      } catch (error) {
        console.log(error.message);
      }
    };
    getData();
  }, [id]);
  

  const handleAdd = () => {
    setQuantity((prevQuantity) => prevQuantity + 1);
  };

  const handleRemove = () => {
    setQuantity((prevQuantity) => Math.max(prevQuantity - 1, 1));
  };

  const handleAddToCart = () => {
    // Handle add to cart
  };

  const handleReviewSubmit = (e) => {
    e.preventDefault();
    // handle review submission, for example, send it to your backend
  };

  return (
    <div className="product-detail-container">
      <Grid container spacing={3}>
        <Grid item xs={12} md={6}>
          <Carousel>
            {images.map((image, index) => (
              <div key={index}>
                <img src={image} alt="Product" />
              </div>
            ))}
          </Carousel>
        </Grid>

        <Grid item xs={12} md={6}>
          <Typography variant="h4" component="div">
            {product.name}
          </Typography>
          <Rating value={product.rating} readOnly />
          <Typography variant="h5" color="text.secondary" component="div">
            ${product.price?.toFixed(2)}
          </Typography>
          <Typography variant="body1" component="div">
            {product.description}
          </Typography>
          <Box sx={{ display: 'flex', alignItems: 'center', mt: 2 }}>
            <IconButton onClick={handleRemove}>
              <Remove />
            </IconButton>
            <TextField value={quantity} variant="outlined" style={{ width: '50px', margin: '0 10px' }} />
            <IconButton onClick={handleAdd}>
              <Add />
            </IconButton>
            <Button variant="contained" color="primary" onClick={handleAddToCart} style={{ marginLeft: '20px' }}>
              Add to Cart
            </Button>
          </Box>
          <Typography variant="body1" component="div" style={{ marginTop: '20px' }}>
            <strong>Category: </strong> {product.category}
          </Typography>
          <Typography variant="body1" component="div">
            <strong>Genre: </strong> {product.genre}
          </Typography>
          <Typography variant="body1" component="div">
            <strong>Publisher: </strong> {product.publisher}
          </Typography>
          <Typography variant="body1" component="div">
            <strong>Release Date: </strong> {new Date(product.releaseDate).toLocaleDateString()}
          </Typography>
        </Grid>
      </Grid>
      
      <Grid container spacing={3}>
        <Grid item xs={12}>
          <Typography variant="h4" component="div">
            Reviews
          </Typography>

          {reviews.map((review, index) => (
            <div key={index}>
              <Typography variant="h6" component="div">
                {review.author} says:
              </Typography>
              <Typography variant="body1" component="div">
                {review.text}
              </Typography>
            </div>
          ))}

          <Typography variant="h5" component="div">
            Write a review:
          </Typography>
          <form onSubmit={handleReviewSubmit}>
            <TextField 
              variant="outlined" 
              label="Your Review" 
              multiline 
              rows={4} 
              value={reviewText} 
              onChange={(e) => setReviewText(e.target.value)}
            />
            <Button type="submit">Submit Review</Button>
          </form>
        </Grid>
      </Grid>

      <Button variant="contained" color="primary" style={{ backgroundColor: '#ff0000', marginTop: '20px' }}>
        <Link to="/products" style={{ textDecoration: 'none', color: '#ffffff' }}>
          Back to Products
        </Link>
      </Button>
    </div>
  );
}
