import { Avatar, Card, CardHeader, CardMedia } from "@mui/material";
import { Product } from "../../product";

interface Props {
  product: Product;
}

export default function ProductCard({ product }: Props) {
  return (
    <Card sx={{ maxWidth: 345 }}>
      <CardHeader
        avatar={<Avatar>{}</Avatar>}
      />
      <CardMedia sx={{ height: 140 }} image="http://picsum.photos/200" />
    </Card>
  );
}
