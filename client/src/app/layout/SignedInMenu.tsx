import { Button, Menu, MenuItem } from "@mui/material";
import React from "react";
import { useAppDispatch, useAppSelector } from "../store/configureStore";
import { signOutUser } from "../../features/account/accountSlice";

export default function SignedInMenu() {
  const dispatch = useAppDispatch();
  const { user } = useAppSelector((state) => state.account);
  const [anchorEl, setAnchorEl] = React.useState<null | HTMLElement>(null);
  const open = Boolean(anchorEl);
  const handleClick = (event: any) => {
    setAnchorEl(event.currentTarget);
  };
  const handleClose = () => {
    setAnchorEl(null);
  };

  return (
    <>
      <Button color="inherit" sx={{ typography: "h6" }} onClick={handleClick}>
        {user?.email}
      </Button>
      <Menu anchorEl={anchorEl} open={open} onClose={handleClose}>
        <MenuItem onClick={handleClose}>Profile</MenuItem>
        <MenuItem onClick={handleClose}>My orders</MenuItem>
        <MenuItem onClick={() => dispatch(signOutUser())}>Logout</MenuItem>
      </Menu>
    </>
  );
}
