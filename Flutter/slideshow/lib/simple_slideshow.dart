import 'package:flutter/material.dart';

class SimpleSlideShow extends StatelessWidget {
  SimpleSlideShow({Key? key}) : super(key: key);
  final PageController ctrl = PageController();
  @override
  Widget build(BuildContext context) {
    return PageView(
      scrollDirection: Axis.vertical,
      controller: ctrl,
      children: [
        Container(color: Colors.green),
        Container(color: Colors.yellow),
        Container(color: Colors.red),
      ],
    );
  }
}
