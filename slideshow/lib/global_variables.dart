import 'package:flutter/material.dart';

class SlideShowData {
  String? imageLink;
  List<String>? tags;
  String? title;
  SlideShowData(this.imageLink, this.tags, this.title);
}

List<SlideShowData> slides = [
  SlideShowData(
      "https://images.pexels.com/photos/2121799/pexels-photo-2121799.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
      ["favorites", "sleepy"],
      "Foxy 1"),
  SlideShowData(
      "https://images.pexels.com/photos/57481/fox-red-fox-red-licking-57481.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
      ["favorites", "energic"],
      "Foxy2"),
  SlideShowData(
      "https://images.pexels.com/photos/977958/pexels-photo-977958.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
      ["favorites", "sleepy"],
      "Foxy3"),
];
