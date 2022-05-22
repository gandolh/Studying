import 'package:flutter/material.dart';
import 'simple_slideshow.dart';
import 'global_variables.dart' as globals;

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  MyApp({Key? key}) : super(key: key);
  final PageController ctrl = PageController();

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        home: Scaffold(
      body: SimpleSlideShow(),
    ));
  }
}

class ComplexSlideshow extends StatefulWidget {
  const ComplexSlideshow({Key? key}) : super(key: key);

  @override
  State<ComplexSlideshow> createState() => _ComplexSlideshowState();
}

class _ComplexSlideshowState extends State<ComplexSlideshow> {
  final PageController ctrl = PageController(viewportFraction: 0.8);

  Stream? slides;
  String activeTag = 'favorites';
  int currentPage = 0;

  @override
  void initState() {
    _queryDb();
    ctrl.addListener(() {
      int next = ctrl.page!.round();
      if (currentPage != next) {
        setState(() {
          currentPage = next;
        });
      }
    });
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return StreamBuilder(
      stream: slides,
      initialData: [],
      builder: (context, AsyncSnapshot snap) {
        List slideList = snap.data.toList();
        return PageView.builder(
          controller: ctrl,
          itemCount: slideList.length + 1,
          itemBuilder: (context, int currentIdx) {
            if (currentIdx == 0) {
              return _buildTagPage();
            } else if (slideList.length >= currentIdx) {
              bool active = currentIdx == currentPage;
              return _buildStoryPage(slideList[currentIdx - 1], active);
            }
            throw 'empty';
          },
        );
      },
    );
  }

  void _queryDb({String tag = 'favorites'}) {
    slides = Stream.fromIterable(globals.slides);
    setState(() {
      activeTag = tag;
    });
  }

  _buildStoryPage(Map data, bool active) {
    final double blur = active ? 30 : 0;
    final double offset = active ? 20 : 0;
    final double top = active ? 100 : 200;
    return AnimatedContainer(
        duration: const Duration(milliseconds: 500),
        curve: Curves.easeOutQuint,
        margin: EdgeInsets.only(top: top, bottom: 50, right: 30),
        decoration: BoxDecoration(
            borderRadius: BorderRadius.circular(20),
            image: DecorationImage(
              fit: BoxFit.cover,
              image: NetworkImage(data['imageLink']),
            ),
            boxShadow: [
              BoxShadow(
                color: Colors.black87,
                blurRadius: blur,
                offset: Offset(offset, offset),
              )
            ]),
        child: Center(
          child: Text(
            data['title'],
            style: const TextStyle(fontSize: 40, color: Colors.white),
          ),
        ));
  }

  _buildTagPage() {
    return Container(
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          const Text(
            "Your Foxes",
            style: TextStyle(fontSize: 40, fontWeight: FontWeight.bold),
          ),
          const Text('Filter', style: TextStyle(color: Colors.black26)),
          _buildButton('favorites'),
          _buildButton('sleepy'),
          _buildButton('energic'),
        ],
      ),
    );
  }

  _buildButton(tag) {
    final color = tag == activeTag ? Colors.purple : Colors.white;
    return TextButton(
      style:
          ButtonStyle(backgroundColor: MaterialStateProperty.all<Color>(color)),
      child: Text('#$tag'),
      onPressed: () => _queryDb(tag: tag),
    );
  }
}
