import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import axios from 'axios';
import '../../Style/ProductDetail.css';

export default function ProductDetail() {
  const [product, setProduct] = useState({});
  const { id } = useParams();

  useEffect(() => {
    const getData = async () => {
      try {
        const { data } = await axios.get(`http://localhost:5000/api/product/${id}`);
        setProduct(data);
      } catch (error) {
        console.log(error.message);
      }
    };
    getData();
  }, [id]);

  return (
    <div className="product-detail-container">
      <div className="product-image">
        <img src={product.image} alt={product.name} />
      </div>
      <div className="product-info">
        <h1>{product.name}</h1>
        <p className="product-description">{product.description}</p>
        <div className="product-meta">
          <p className="product-price">${product.price}</p>
          <p className="product-rating">{product.rating}</p>
          <p className="product-category">Category: {product.category}</p>
          <p className="product-publisher">Publisher: {product.publisher}</p>
          <p className="product-release-date">Release Date: {product.releaseDate}</p>
        </div>
        <button className="product-button">Add to Cart</button>
      </div>
      <div className="related-products">
        <h2>Related Products</h2>
        
      </div>
      <div className="product-reviews">
        <h2>Customer Reviews</h2>
       
      </div>
    </div>
  );
}
