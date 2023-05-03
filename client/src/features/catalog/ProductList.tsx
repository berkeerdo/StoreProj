import { Grid, List } from "@mui/material";
import { Product } from "../../product";
import ProductCard from "./ProductCard";

interface Props {
  products: Product[];
}

export default function ProductList(props: Props) {
  return (
    <Grid container spacing={3}>
      {props.products.map((product) => (
        <Grid item xs={4} key={product.id}>
          <ProductCard product={product} />
        </Grid>
      ))}
    </Grid>
  );
}
